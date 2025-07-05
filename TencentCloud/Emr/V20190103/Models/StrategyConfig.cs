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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StrategyConfig : AbstractModel
    {
        
        /// <summary>
        /// 0:关闭滚动重启
        /// 1:开启滚动启动
        /// </summary>
        [JsonProperty("RollingRestartSwitch")]
        public long? RollingRestartSwitch{ get; set; }

        /// <summary>
        /// 滚动重启每批次的重启数量，最大重启台数为 99999 台
        /// </summary>
        [JsonProperty("BatchSize")]
        public long? BatchSize{ get; set; }

        /// <summary>
        /// 滚动重启每批停止等待时间 ,最大间隔为 5 分钟 单位是秒
        /// </summary>
        [JsonProperty("TimeWait")]
        public long? TimeWait{ get; set; }

        /// <summary>
        /// 操作失败处理策略，0:失败阻塞, 1:失败自动跳过
        /// </summary>
        [JsonProperty("DealOnFail")]
        public long? DealOnFail{ get; set; }

        /// <summary>
        /// 指令需要指定的参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Args")]
        public Arg[] Args{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RollingRestartSwitch", this.RollingRestartSwitch);
            this.SetParamSimple(map, prefix + "BatchSize", this.BatchSize);
            this.SetParamSimple(map, prefix + "TimeWait", this.TimeWait);
            this.SetParamSimple(map, prefix + "DealOnFail", this.DealOnFail);
            this.SetParamArrayObj(map, prefix + "Args.", this.Args);
        }
    }
}

