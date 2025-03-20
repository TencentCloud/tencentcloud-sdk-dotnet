/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UsageDetail : AbstractModel
    {
        
        /// <summary>
        /// 子客企业标识
        /// </summary>
        [JsonProperty("ProxyOrganizationOpenId")]
        public string ProxyOrganizationOpenId{ get; set; }

        /// <summary>
        /// 子客企业名
        /// </summary>
        [JsonProperty("ProxyOrganizationName")]
        public string ProxyOrganizationName{ get; set; }

        /// <summary>
        /// 对应的消耗日期, **如果是汇总数据则为1970-01-01**
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// 消耗合同数量
        /// </summary>
        [JsonProperty("Usage")]
        public ulong? Usage{ get; set; }

        /// <summary>
        /// 撤回合同数量
        /// </summary>
        [JsonProperty("Cancel")]
        public ulong? Cancel{ get; set; }

        /// <summary>
        /// 消耗渠道
        /// </summary>
        [JsonProperty("FlowChannel")]
        public string FlowChannel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProxyOrganizationOpenId", this.ProxyOrganizationOpenId);
            this.SetParamSimple(map, prefix + "ProxyOrganizationName", this.ProxyOrganizationName);
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamSimple(map, prefix + "Usage", this.Usage);
            this.SetParamSimple(map, prefix + "Cancel", this.Cancel);
            this.SetParamSimple(map, prefix + "FlowChannel", this.FlowChannel);
        }
    }
}

