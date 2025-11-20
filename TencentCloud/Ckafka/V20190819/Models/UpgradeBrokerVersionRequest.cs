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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpgradeBrokerVersionRequest : AbstractModel
    {
        
        /// <summary>
        /// ckafka集群实例Id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 1.平滑升配.2.垂直升配
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        [JsonProperty("SourceVersion")]
        public string SourceVersion{ get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        [JsonProperty("TargetVersion")]
        public string TargetVersion{ get; set; }

        /// <summary>
        /// 延迟时间
        /// </summary>
        [JsonProperty("DelayTimeStamp")]
        public string DelayTimeStamp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "SourceVersion", this.SourceVersion);
            this.SetParamSimple(map, prefix + "TargetVersion", this.TargetVersion);
            this.SetParamSimple(map, prefix + "DelayTimeStamp", this.DelayTimeStamp);
        }
    }
}

