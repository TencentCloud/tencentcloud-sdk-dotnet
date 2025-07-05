/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Ms.V20180408.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RequestLocalTaskResponse : AbstractModel
    {
        
        /// <summary>
        /// 返回的任务id
        /// </summary>
        [JsonProperty("Sid")]
        public string Sid{ get; set; }

        /// <summary>
        /// 任务文件的mk5
        /// </summary>
        [JsonProperty("SrcFileMd5")]
        public string SrcFileMd5{ get; set; }

        /// <summary>
        /// 文件大小，可不传
        /// </summary>
        [JsonProperty("SrcFileSize")]
        public long? SrcFileSize{ get; set; }

        /// <summary>
        /// 任务文件的下载地址，必须无鉴权可下载
        /// </summary>
        [JsonProperty("SrcFileUrl")]
        public string SrcFileUrl{ get; set; }

        /// <summary>
        /// release: 需要INFO-PLIST文件，会生成工具部署安装包，并带有license文件，绑定机器；nobind不需要INFO-PLIST文件，不绑定机器
        /// </summary>
        [JsonProperty("SrcFileType")]
        public string SrcFileType{ get; set; }

        /// <summary>
        /// enterprise
        /// trial
        /// </summary>
        [JsonProperty("SrcFileVersion")]
        public string SrcFileVersion{ get; set; }

        /// <summary>
        /// 补充字段
        /// </summary>
        [JsonProperty("EncryptParam")]
        public string EncryptParam{ get; set; }

        /// <summary>
        /// 任务状态
        /// </summary>
        [JsonProperty("EncryptState")]
        public long? EncryptState{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Sid", this.Sid);
            this.SetParamSimple(map, prefix + "SrcFileMd5", this.SrcFileMd5);
            this.SetParamSimple(map, prefix + "SrcFileSize", this.SrcFileSize);
            this.SetParamSimple(map, prefix + "SrcFileUrl", this.SrcFileUrl);
            this.SetParamSimple(map, prefix + "SrcFileType", this.SrcFileType);
            this.SetParamSimple(map, prefix + "SrcFileVersion", this.SrcFileVersion);
            this.SetParamSimple(map, prefix + "EncryptParam", this.EncryptParam);
            this.SetParamSimple(map, prefix + "EncryptState", this.EncryptState);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

