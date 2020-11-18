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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DelayDistribution : AbstractModel
    {
        
        /// <summary>
        /// 分布阶梯，延时和Ladder值的对应关系：
        /// [0ms,1ms]: 1；
        /// [1ms,5ms]: 5；
        /// [5ms,10ms]: 10；
        /// [10ms,50ms]: 50；
        /// [50ms,200ms]: 200；
        /// [200ms,∞]: -1。
        /// </summary>
        [JsonProperty("Ladder")]
        public long? Ladder{ get; set; }

        /// <summary>
        /// 延时处于当前分布阶梯的命令数量，个。
        /// </summary>
        [JsonProperty("Size")]
        public long? Size{ get; set; }

        /// <summary>
        /// 修改时间。
        /// </summary>
        [JsonProperty("Updatetime")]
        public long? Updatetime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Ladder", this.Ladder);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "Updatetime", this.Updatetime);
        }
    }
}

