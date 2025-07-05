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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateVerifyRecordResponse : AbstractModel
    {
        
        /// <summary>
        /// 子解析
        /// </summary>
        [JsonProperty("SubDomain")]
        public string SubDomain{ get; set; }

        /// <summary>
        /// 解析值
        /// </summary>
        [JsonProperty("Record")]
        public string Record{ get; set; }

        /// <summary>
        /// 解析类型
        /// </summary>
        [JsonProperty("RecordType")]
        public string RecordType{ get; set; }

        /// <summary>
        /// 文件验证 URL 指引
        /// </summary>
        [JsonProperty("FileVerifyUrl")]
        public string FileVerifyUrl{ get; set; }

        /// <summary>
        /// 文件校验域名列表
        /// </summary>
        [JsonProperty("FileVerifyDomains")]
        public string[] FileVerifyDomains{ get; set; }

        /// <summary>
        /// 文件校验文件名
        /// </summary>
        [JsonProperty("FileVerifyName")]
        public string FileVerifyName{ get; set; }

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
            this.SetParamSimple(map, prefix + "SubDomain", this.SubDomain);
            this.SetParamSimple(map, prefix + "Record", this.Record);
            this.SetParamSimple(map, prefix + "RecordType", this.RecordType);
            this.SetParamSimple(map, prefix + "FileVerifyUrl", this.FileVerifyUrl);
            this.SetParamArraySimple(map, prefix + "FileVerifyDomains.", this.FileVerifyDomains);
            this.SetParamSimple(map, prefix + "FileVerifyName", this.FileVerifyName);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

