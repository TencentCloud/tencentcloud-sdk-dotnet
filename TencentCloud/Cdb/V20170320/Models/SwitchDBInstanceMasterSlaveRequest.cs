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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SwitchDBInstanceMasterSlaveRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>实例 ID。</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>目标从实例。可选值：&quot;first&quot; - 第一备机；&quot;second&quot; - 第二备机；&quot;third&quot; - 第三备机。默认值为 &quot;first&quot;，仅多可用区实例支持设置为 &quot;second&quot;。</p>
        /// </summary>
        [JsonProperty("DstSlave")]
        public string DstSlave{ get; set; }

        /// <summary>
        /// <p>是否强制切换。默认为 False。注意，若设置强制切换为 True，实例存在丢失数据的风险，请谨慎使用。</p>
        /// </summary>
        [JsonProperty("ForceSwitch")]
        [System.Obsolete]
        public bool? ForceSwitch{ get; set; }

        /// <summary>
        /// <p>是否时间窗内切换。默认为 False，即不在时间窗内切换。注意，如果设置了 ForceSwitch 参数为 True，则该参数不生效。</p>
        /// </summary>
        [JsonProperty("WaitSwitch")]
        public bool? WaitSwitch{ get; set; }

        /// <summary>
        /// <p>集群版实例指定节点 ID 发起主从切换。</p>
        /// </summary>
        [JsonProperty("DstNodeId")]
        public string DstNodeId{ get; set; }

        /// <summary>
        /// <p>等待主备位点差收敛到阈值以内的最长时间,范围：30s-3600s</p>
        /// </summary>
        [JsonProperty("SyncTimeout")]
        public long? SyncTimeout{ get; set; }

        /// <summary>
        /// <p>slave 执行位点和读到位点差值，在最长等待时间内，位点差需小于该值才启动切换</p>
        /// </summary>
        [JsonProperty("SyncDistance")]
        public string SyncDistance{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "DstSlave", this.DstSlave);
            this.SetParamSimple(map, prefix + "ForceSwitch", this.ForceSwitch);
            this.SetParamSimple(map, prefix + "WaitSwitch", this.WaitSwitch);
            this.SetParamSimple(map, prefix + "DstNodeId", this.DstNodeId);
            this.SetParamSimple(map, prefix + "SyncTimeout", this.SyncTimeout);
            this.SetParamSimple(map, prefix + "SyncDistance", this.SyncDistance);
        }
    }
}

