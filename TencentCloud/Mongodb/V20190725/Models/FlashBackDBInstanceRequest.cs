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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FlashBackDBInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// 开启按 Key 回档的实例 ID。请登录 [MongoDB 控制台](https://console.cloud.tencent.com/mongodb)在实例列表复制需开启按 Key 回档的实例 ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 指定数据回档的具体时间点，即将数据恢复到指定时间点的状态。
        /// </summary>
        [JsonProperty("TargetFlashbackTime")]
        public string TargetFlashbackTime{ get; set; }

        /// <summary>
        /// 指定回档数据的目标库表。
        /// </summary>
        [JsonProperty("TargetDatabases")]
        public FlashbackDatabase[] TargetDatabases{ get; set; }

        /// <summary>
        /// 数据回档的目标实例 ID。请登录 [MongoDB 控制台](https://console.cloud.tencent.com/mongodb)在实例列表复制目标实例 ID。
        /// </summary>
        [JsonProperty("TargetInstanceId")]
        public string TargetInstanceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "TargetFlashbackTime", this.TargetFlashbackTime);
            this.SetParamArrayObj(map, prefix + "TargetDatabases.", this.TargetDatabases);
            this.SetParamSimple(map, prefix + "TargetInstanceId", this.TargetInstanceId);
        }
    }
}

