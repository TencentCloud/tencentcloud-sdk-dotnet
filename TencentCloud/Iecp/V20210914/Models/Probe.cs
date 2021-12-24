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

namespace TencentCloud.Iecp.V20210914.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Probe : AbstractModel
    {
        
        /// <summary>
        /// 启动后，延迟探测时间 单位:秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InitialDelaySeconds")]
        public long? InitialDelaySeconds{ get; set; }

        /// <summary>
        /// 探测间隔，单位：秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PeriodSeconds")]
        public long? PeriodSeconds{ get; set; }

        /// <summary>
        /// 探测超时时间 单位：秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimeoutSeconds")]
        public long? TimeoutSeconds{ get; set; }

        /// <summary>
        /// 失败后检查成功的最小连续成功次数。默认为1.活跃度必须为1。最小值为1
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SuccessThreshold")]
        public long? SuccessThreshold{ get; set; }

        /// <summary>
        /// 当Pod成功启动且检查失败时，放弃之前尝试次数。默认为3.最小值为1
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FailureThreshold")]
        public long? FailureThreshold{ get; set; }

        /// <summary>
        /// HTTP探测配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HttpProbe")]
        public HttpProbe HttpProbe{ get; set; }

        /// <summary>
        /// TCP探测配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TcpProbe")]
        public TcpProbe TcpProbe{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InitialDelaySeconds", this.InitialDelaySeconds);
            this.SetParamSimple(map, prefix + "PeriodSeconds", this.PeriodSeconds);
            this.SetParamSimple(map, prefix + "TimeoutSeconds", this.TimeoutSeconds);
            this.SetParamSimple(map, prefix + "SuccessThreshold", this.SuccessThreshold);
            this.SetParamSimple(map, prefix + "FailureThreshold", this.FailureThreshold);
            this.SetParamObj(map, prefix + "HttpProbe.", this.HttpProbe);
            this.SetParamObj(map, prefix + "TcpProbe.", this.TcpProbe);
        }
    }
}

