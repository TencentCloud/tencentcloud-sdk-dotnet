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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SwitchInstanceVipRequest : AbstractModel
    {
        
        /// <summary>
        /// 源实例ID
        /// </summary>
        [JsonProperty("SrcInstanceId")]
        public string SrcInstanceId{ get; set; }

        /// <summary>
        /// 目标实例ID
        /// </summary>
        [JsonProperty("DstInstanceId")]
        public string DstInstanceId{ get; set; }

        /// <summary>
        /// 单位为秒。源实例与目标实例间DTS已断开时间，如果DTS断开时间大于TimeDelay，则不切换VIP，建议尽量根据业务设置一个可接受的值。
        /// </summary>
        [JsonProperty("TimeDelay")]
        public long? TimeDelay{ get; set; }

        /// <summary>
        /// 在DTS断开的情况下是否强制切换。1：强制切换，0：不强制切换
        /// </summary>
        [JsonProperty("ForceSwitch")]
        public long? ForceSwitch{ get; set; }

        /// <summary>
        /// now: 立即切换，syncComplete：等待同步完成后切换
        /// </summary>
        [JsonProperty("SwitchTime")]
        public string SwitchTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SrcInstanceId", this.SrcInstanceId);
            this.SetParamSimple(map, prefix + "DstInstanceId", this.DstInstanceId);
            this.SetParamSimple(map, prefix + "TimeDelay", this.TimeDelay);
            this.SetParamSimple(map, prefix + "ForceSwitch", this.ForceSwitch);
            this.SetParamSimple(map, prefix + "SwitchTime", this.SwitchTime);
        }
    }
}

