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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeProductEventListOverView : AbstractModel
    {
        
        /// <summary>
        /// 状态变更的事件数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StatusChangeAmount")]
        public long? StatusChangeAmount{ get; set; }

        /// <summary>
        /// 告警状态未配置的事件数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UnConfigAlarmAmount")]
        public long? UnConfigAlarmAmount{ get; set; }

        /// <summary>
        /// 异常事件数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UnNormalEventAmount")]
        public long? UnNormalEventAmount{ get; set; }

        /// <summary>
        /// 未恢复的事件数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UnRecoverAmount")]
        public long? UnRecoverAmount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StatusChangeAmount", this.StatusChangeAmount);
            this.SetParamSimple(map, prefix + "UnConfigAlarmAmount", this.UnConfigAlarmAmount);
            this.SetParamSimple(map, prefix + "UnNormalEventAmount", this.UnNormalEventAmount);
            this.SetParamSimple(map, prefix + "UnRecoverAmount", this.UnRecoverAmount);
        }
    }
}

