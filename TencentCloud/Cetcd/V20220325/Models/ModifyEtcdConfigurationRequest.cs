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

namespace TencentCloud.Cetcd.V20220325.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyEtcdConfigurationRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 自动压缩设置
        /// </summary>
        [JsonProperty("AutoCompactionSettings")]
        public EtcdAutoCompactionSettings AutoCompactionSettings{ get; set; }

        /// <summary>
        /// 监控设置
        /// </summary>
        [JsonProperty("MonitorSettings")]
        public EtcdMonitorSettings MonitorSettings{ get; set; }

        /// <summary>
        /// 计费类型
        /// PREPAID：预付费
        /// POSTPAID_BY_HOUR：后付费
        /// </summary>
        [JsonProperty("ChargeType")]
        public string ChargeType{ get; set; }

        /// <summary>
        /// 实例配置信息
        /// </summary>
        [JsonProperty("InstanceConfig")]
        public InstanceConfig InstanceConfig{ get; set; }

        /// <summary>
        /// 预付费配置信息
        /// </summary>
        [JsonProperty("PrepaidConfig")]
        public ChargePrepaidConfig PrepaidConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamObj(map, prefix + "AutoCompactionSettings.", this.AutoCompactionSettings);
            this.SetParamObj(map, prefix + "MonitorSettings.", this.MonitorSettings);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
            this.SetParamObj(map, prefix + "InstanceConfig.", this.InstanceConfig);
            this.SetParamObj(map, prefix + "PrepaidConfig.", this.PrepaidConfig);
        }
    }
}

