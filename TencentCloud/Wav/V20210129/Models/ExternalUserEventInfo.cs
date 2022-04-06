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

namespace TencentCloud.Wav.V20210129.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExternalUserEventInfo : AbstractModel
    {
        
        /// <summary>
        /// 事件编码, 添加外部联系人(ADD_EXTERNAL_CUSTOMER)/成员删除外部联系人(DELETE_EXTERNAL_CUSTOMER)/外部联系人删除成员(DELETE_FOLLOW_USER)
        /// </summary>
        [JsonProperty("EventCode")]
        public string EventCode{ get; set; }

        /// <summary>
        /// 外部联系人id
        /// </summary>
        [JsonProperty("ExternalUserId")]
        public string ExternalUserId{ get; set; }

        /// <summary>
        /// 企微SaaS的成员id
        /// </summary>
        [JsonProperty("SalesId")]
        public string SalesId{ get; set; }

        /// <summary>
        /// 事件上报时间戳，单位：秒
        /// </summary>
        [JsonProperty("EventTime")]
        public ulong? EventTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EventCode", this.EventCode);
            this.SetParamSimple(map, prefix + "ExternalUserId", this.ExternalUserId);
            this.SetParamSimple(map, prefix + "SalesId", this.SalesId);
            this.SetParamSimple(map, prefix + "EventTime", this.EventTime);
        }
    }
}

