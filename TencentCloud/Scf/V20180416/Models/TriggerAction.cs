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

namespace TencentCloud.Scf.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TriggerAction : AbstractModel
    {
        
        /// <summary>
        /// 定时预置名称
        /// </summary>
        [JsonProperty("TriggerName")]
        public string TriggerName{ get; set; }

        /// <summary>
        /// 定时预置并发数量
        /// </summary>
        [JsonProperty("TriggerProvisionedConcurrencyNum")]
        public ulong? TriggerProvisionedConcurrencyNum{ get; set; }

        /// <summary>
        /// 设置定时触发器的时间配置，cron表达式。Cron 表达式有七个必需字段，按空格分隔。
        /// </summary>
        [JsonProperty("TriggerCronConfig")]
        public string TriggerCronConfig{ get; set; }

        /// <summary>
        /// 预置类型 Default
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProvisionedType")]
        public string ProvisionedType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TriggerName", this.TriggerName);
            this.SetParamSimple(map, prefix + "TriggerProvisionedConcurrencyNum", this.TriggerProvisionedConcurrencyNum);
            this.SetParamSimple(map, prefix + "TriggerCronConfig", this.TriggerCronConfig);
            this.SetParamSimple(map, prefix + "ProvisionedType", this.ProvisionedType);
        }
    }
}

