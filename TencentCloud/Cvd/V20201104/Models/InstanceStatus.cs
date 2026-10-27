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

namespace TencentCloud.Cvd.V20201104.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceStatus : AbstractModel
    {
        
        /// <summary>
        /// 实例id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例状态
        /// PENDING：表示创建中
        /// LAUNCH_FAILED：表示创建失败
        /// RUNNING：表示运行中
        /// STOPPED：表示关机
        /// STARTING：表示开机中
        /// STOPPING：表示关机中
        /// REBOOTING：表示重启中
        /// SHUTDOWN：表示停止待销毁
        /// TERMINATING：表示销毁中
        /// DELETED：表示资源已经销毁，这个状态是业务层面的状态，cvm如果销毁了，在cvm测资源已经不存在了
        /// FAILED：表示资源创建失败.这个是业务层面的状态
        /// ROLLBACKING：表示机器正在回滚中
        /// RESETTING：表示机器正在重置中
        /// USING：表示机器正在使用中
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 只有在Status为RUNNING时候，当前值才有意义
        /// 取值范围：
        /// 0:Unknown
        /// 1:Connected 
        /// 2:Disconnected 
        /// 3:Terminated
        /// 4:PreparingSession
        /// 5:Active
        /// 6:Reconnecting
        /// 7:NonBrokeredSession
        /// 8:Other
        /// 9:Pending
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SessionState")]
        public long? SessionState{ get; set; }

        /// <summary>
        /// 此字段只有在Status为USING时，才有效。
        /// 字段意义：表示桌面当前session空闲时间（客户没有鼠标，键盘等操作），单位秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IdleSeconds")]
        public float? IdleSeconds{ get; set; }

        /// <summary>
        /// 当前状态改变的时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StatusChangeTime")]
        public long? StatusChangeTime{ get; set; }

        /// <summary>
        /// 实例最近一次操作类型
        /// </summary>
        [JsonProperty("LatestOperation")]
        public string LatestOperation{ get; set; }

        /// <summary>
        /// 实例最近一次操作状态
        /// </summary>
        [JsonProperty("LatestOperationState")]
        public string LatestOperationState{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "SessionState", this.SessionState);
            this.SetParamSimple(map, prefix + "IdleSeconds", this.IdleSeconds);
            this.SetParamSimple(map, prefix + "StatusChangeTime", this.StatusChangeTime);
            this.SetParamSimple(map, prefix + "LatestOperation", this.LatestOperation);
            this.SetParamSimple(map, prefix + "LatestOperationState", this.LatestOperationState);
        }
    }
}

