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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AutoCalloutTaskInfo : AbstractModel
    {
        
        /// <summary>
        /// 任务名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 被叫数量
        /// </summary>
        [JsonProperty("CalleeCount")]
        public ulong? CalleeCount{ get; set; }

        /// <summary>
        /// 主叫号码列表
        /// </summary>
        [JsonProperty("Callers")]
        public string[] Callers{ get; set; }

        /// <summary>
        /// 起始时间戳
        /// </summary>
        [JsonProperty("NotBefore")]
        public long? NotBefore{ get; set; }

        /// <summary>
        /// 结束时间戳
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NotAfter")]
        public long? NotAfter{ get; set; }

        /// <summary>
        /// 任务使用的IvrId
        /// </summary>
        [JsonProperty("IvrId")]
        public ulong? IvrId{ get; set; }

        /// <summary>
        /// 任务状态：
        /// 0初始：任务创建，呼叫未开始
        /// 1运行中
        /// 2 已完成：任务中所有呼叫完成
        /// 3结束中：任务到期，但仍有部分呼叫未结束
        /// 4已结束：任务到期终止
        /// 5已暂停：可恢复继续执行
        /// </summary>
        [JsonProperty("State")]
        public ulong? State{ get; set; }

        /// <summary>
        /// 任务Id
        /// </summary>
        [JsonProperty("TaskId")]
        public ulong? TaskId{ get; set; }

        /// <summary>
        /// 最大振铃时长，达到时长阈值自动挂断。 仅自携号码支持当前参数
        /// </summary>
        [JsonProperty("MaxRingTimeoutSecond")]
        public long? MaxRingTimeoutSecond{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "CalleeCount", this.CalleeCount);
            this.SetParamArraySimple(map, prefix + "Callers.", this.Callers);
            this.SetParamSimple(map, prefix + "NotBefore", this.NotBefore);
            this.SetParamSimple(map, prefix + "NotAfter", this.NotAfter);
            this.SetParamSimple(map, prefix + "IvrId", this.IvrId);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "MaxRingTimeoutSecond", this.MaxRingTimeoutSecond);
        }
    }
}

