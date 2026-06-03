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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ArchiveFlowResult : AbstractModel
    {
        
        /// <summary>
        /// <p>归档合同id</p>
        /// </summary>
        [JsonProperty("FlowId")]
        public string FlowId{ get; set; }

        /// <summary>
        /// <p>合同处理结果</p><p>枚举值：</p><ul><li>0： 成功</li><li>1： 失败</li></ul>
        /// </summary>
        [JsonProperty("ArchiveFlowStatus")]
        public long? ArchiveFlowStatus{ get; set; }

        /// <summary>
        /// <p>业务自定义id</p>
        /// </summary>
        [JsonProperty("BusinessId")]
        public string BusinessId{ get; set; }

        /// <summary>
        /// <p>资源ID列表</p>
        /// </summary>
        [JsonProperty("ResourceIdList")]
        public string[] ResourceIdList{ get; set; }

        /// <summary>
        /// <p>错误信息</p>
        /// </summary>
        [JsonProperty("ErrorMessage")]
        public string ErrorMessage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FlowId", this.FlowId);
            this.SetParamSimple(map, prefix + "ArchiveFlowStatus", this.ArchiveFlowStatus);
            this.SetParamSimple(map, prefix + "BusinessId", this.BusinessId);
            this.SetParamArraySimple(map, prefix + "ResourceIdList.", this.ResourceIdList);
            this.SetParamSimple(map, prefix + "ErrorMessage", this.ErrorMessage);
        }
    }
}

