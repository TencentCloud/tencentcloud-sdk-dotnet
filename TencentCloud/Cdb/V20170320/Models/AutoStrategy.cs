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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AutoStrategy : AbstractModel
    {
        
        /// <summary>
        /// 自动扩容阈值，可选值70、80、90，代表CPU利用率达到70%、80%、90%时后台进行自动扩容
        /// </summary>
        [JsonProperty("ExpandThreshold")]
        public long? ExpandThreshold{ get; set; }

        /// <summary>
        /// 自动扩容观测周期，单位s，可选值1、3、5、10、15、30。后台会按照配置的周期进行扩容判断。
        /// </summary>
        [JsonProperty("ExpandPeriod")]
        public long? ExpandPeriod{ get; set; }

        /// <summary>
        /// 自动缩容阈值，可选值10、20、30，代表CPU利用率达到10%、20%、30%时后台进行自动缩容
        /// </summary>
        [JsonProperty("ShrinkThreshold")]
        public long? ShrinkThreshold{ get; set; }

        /// <summary>
        /// 自动缩容观测周期，单位s，可选值5、10、15、30。后台会按照配置的周期进行缩容判断。
        /// </summary>
        [JsonProperty("ShrinkPeriod")]
        public long? ShrinkPeriod{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ExpandThreshold", this.ExpandThreshold);
            this.SetParamSimple(map, prefix + "ExpandPeriod", this.ExpandPeriod);
            this.SetParamSimple(map, prefix + "ShrinkThreshold", this.ShrinkThreshold);
            this.SetParamSimple(map, prefix + "ShrinkPeriod", this.ShrinkPeriod);
        }
    }
}

