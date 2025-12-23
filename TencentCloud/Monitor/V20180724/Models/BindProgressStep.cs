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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BindProgressStep : AbstractModel
    {
        
        /// <summary>
        /// 结束时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndAt")]
        public string EndAt{ get; set; }

        /// <summary>
        /// 错误信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FailedMsg")]
        public string FailedMsg{ get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("LifeState")]
        public string LifeState{ get; set; }

        /// <summary>
        /// 开始时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartAt")]
        public string StartAt{ get; set; }

        /// <summary>
        /// 任务进程
        /// "prepare_env"   // 准备环境,安装instance EKS
        /// "check_target"  // 检查target是否为running
        /// "install_crd"   // 安装需要测crd
        /// "install_rbac"  // 安装rbac
        /// "install_agent" // 安装agent
        /// "install_cr"    // 安装prometheus CR
        /// "install_basic" // 安装基础采集信息，标记target状态为normal
        /// </summary>
        [JsonProperty("Step")]
        public string Step{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EndAt", this.EndAt);
            this.SetParamSimple(map, prefix + "FailedMsg", this.FailedMsg);
            this.SetParamSimple(map, prefix + "LifeState", this.LifeState);
            this.SetParamSimple(map, prefix + "StartAt", this.StartAt);
            this.SetParamSimple(map, prefix + "Step", this.Step);
        }
    }
}

