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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SaveDocResponse : AbstractModel
    {
        
        /// <summary>
        /// 文档ID
        /// </summary>
        [JsonProperty("DocBizId")]
        public string DocBizId{ get; set; }

        /// <summary>
        /// 导入错误信息
        /// </summary>
        [JsonProperty("ErrorMsg")]
        public string ErrorMsg{ get; set; }

        /// <summary>
        /// 错误链接
        /// </summary>
        [JsonProperty("ErrorLink")]
        public string ErrorLink{ get; set; }

        /// <summary>
        /// 错误链接文本
        /// </summary>
        [JsonProperty("ErrorLinkText")]
        public string ErrorLinkText{ get; set; }

        /// <summary>
        /// 重复类型，0：未重复，其他取值请参考入参DuplicateFileHandle结构体的CheckType字段
        /// </summary>
        [JsonProperty("DuplicateFileCheckType")]
        public ulong? DuplicateFileCheckType{ get; set; }

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
            this.SetParamSimple(map, prefix + "DocBizId", this.DocBizId);
            this.SetParamSimple(map, prefix + "ErrorMsg", this.ErrorMsg);
            this.SetParamSimple(map, prefix + "ErrorLink", this.ErrorLink);
            this.SetParamSimple(map, prefix + "ErrorLinkText", this.ErrorLinkText);
            this.SetParamSimple(map, prefix + "DuplicateFileCheckType", this.DuplicateFileCheckType);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

