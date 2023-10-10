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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AttackSourceNode : AbstractModel
    {
        
        /// <summary>
        /// 事件ID，为空的时候表示没有对应事件
        /// </summary>
        [JsonProperty("EventId")]
        public ulong? EventId{ get; set; }

        /// <summary>
        /// BRUTEFORCE:密码破解、MALWARE:木马、BASH:高危命令、RISK_DNS:恶意请求、LOGIN:异地登录、HOST:主机节点, TIME_ORDER：通用节点
        /// </summary>
        [JsonProperty("EventType")]
        public string EventType{ get; set; }

        /// <summary>
        /// 节点ip 当节点为HOST时
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// 等级  0：提示，1：低危,  2：中危,  3：高危,  4：严重
        /// </summary>
        [JsonProperty("Level")]
        public ulong? Level{ get; set; }

        /// <summary>
        /// 节点ID
        /// </summary>
        [JsonProperty("NodeId")]
        public string NodeId{ get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 通用节点的描述
        /// </summary>
        [JsonProperty("NodeDesc")]
        public string NodeDesc{ get; set; }

        /// <summary>
        /// 时间线编号，同一个编号的节点属于同一个时间线
        /// </summary>
        [JsonProperty("TimeLineNum")]
        public ulong? TimeLineNum{ get; set; }

        /// <summary>
        /// 节点详情
        /// </summary>
        [JsonProperty("NodeDetail")]
        public string NodeDetail{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EventId", this.EventId);
            this.SetParamSimple(map, prefix + "EventType", this.EventType);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "NodeId", this.NodeId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "NodeDesc", this.NodeDesc);
            this.SetParamSimple(map, prefix + "TimeLineNum", this.TimeLineNum);
            this.SetParamSimple(map, prefix + "NodeDetail", this.NodeDetail);
        }
    }
}

