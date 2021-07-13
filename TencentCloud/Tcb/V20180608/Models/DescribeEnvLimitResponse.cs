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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeEnvLimitResponse : AbstractModel
    {
        
        /// <summary>
        /// 环境总数上限
        /// </summary>
        [JsonProperty("MaxEnvNum")]
        public long? MaxEnvNum{ get; set; }

        /// <summary>
        /// 目前环境总数
        /// </summary>
        [JsonProperty("CurrentEnvNum")]
        public long? CurrentEnvNum{ get; set; }

        /// <summary>
        /// 免费环境数量上限
        /// </summary>
        [JsonProperty("MaxFreeEnvNum")]
        public long? MaxFreeEnvNum{ get; set; }

        /// <summary>
        /// 目前免费环境数量
        /// </summary>
        [JsonProperty("CurrentFreeEnvNum")]
        public long? CurrentFreeEnvNum{ get; set; }

        /// <summary>
        /// 总计允许销毁环境次数上限
        /// </summary>
        [JsonProperty("MaxDeleteTotal")]
        public long? MaxDeleteTotal{ get; set; }

        /// <summary>
        /// 目前已销毁环境次数
        /// </summary>
        [JsonProperty("CurrentDeleteTotal")]
        public long? CurrentDeleteTotal{ get; set; }

        /// <summary>
        /// 每月允许销毁环境次数上限
        /// </summary>
        [JsonProperty("MaxDeleteMonthly")]
        public long? MaxDeleteMonthly{ get; set; }

        /// <summary>
        /// 本月已销毁环境次数
        /// </summary>
        [JsonProperty("CurrentDeleteMonthly")]
        public long? CurrentDeleteMonthly{ get; set; }

        /// <summary>
        /// 微信网关体验版可购买月份数
        /// </summary>
        [JsonProperty("MaxFreeTrialNum")]
        public long? MaxFreeTrialNum{ get; set; }

        /// <summary>
        /// 微信网关体验版已购买月份数
        /// </summary>
        [JsonProperty("CurrentFreeTrialNum")]
        public long? CurrentFreeTrialNum{ get; set; }

        /// <summary>
        /// 转支付限额总数
        /// </summary>
        [JsonProperty("ChangePayTotal")]
        public long? ChangePayTotal{ get; set; }

        /// <summary>
        /// 当前已用转支付次数
        /// </summary>
        [JsonProperty("CurrentChangePayTotal")]
        public long? CurrentChangePayTotal{ get; set; }

        /// <summary>
        /// 转支付每月限额
        /// </summary>
        [JsonProperty("ChangePayMonthly")]
        public long? ChangePayMonthly{ get; set; }

        /// <summary>
        /// 本月已用转支付额度
        /// </summary>
        [JsonProperty("CurrentChangePayMonthly")]
        public long? CurrentChangePayMonthly{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MaxEnvNum", this.MaxEnvNum);
            this.SetParamSimple(map, prefix + "CurrentEnvNum", this.CurrentEnvNum);
            this.SetParamSimple(map, prefix + "MaxFreeEnvNum", this.MaxFreeEnvNum);
            this.SetParamSimple(map, prefix + "CurrentFreeEnvNum", this.CurrentFreeEnvNum);
            this.SetParamSimple(map, prefix + "MaxDeleteTotal", this.MaxDeleteTotal);
            this.SetParamSimple(map, prefix + "CurrentDeleteTotal", this.CurrentDeleteTotal);
            this.SetParamSimple(map, prefix + "MaxDeleteMonthly", this.MaxDeleteMonthly);
            this.SetParamSimple(map, prefix + "CurrentDeleteMonthly", this.CurrentDeleteMonthly);
            this.SetParamSimple(map, prefix + "MaxFreeTrialNum", this.MaxFreeTrialNum);
            this.SetParamSimple(map, prefix + "CurrentFreeTrialNum", this.CurrentFreeTrialNum);
            this.SetParamSimple(map, prefix + "ChangePayTotal", this.ChangePayTotal);
            this.SetParamSimple(map, prefix + "CurrentChangePayTotal", this.CurrentChangePayTotal);
            this.SetParamSimple(map, prefix + "ChangePayMonthly", this.ChangePayMonthly);
            this.SetParamSimple(map, prefix + "CurrentChangePayMonthly", this.CurrentChangePayMonthly);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

