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

namespace TencentCloud.Cdwdoris.V20211228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SnapshotRemainPolicy : AbstractModel
    {
        
        /// <summary>
        /// 0-不主动删除；1-超过指定时间周期自动删除；2-保留指定数据快照
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// 保留快照的时间
        /// </summary>
        [JsonProperty("RemainDays")]
        public long? RemainDays{ get; set; }

        /// <summary>
        /// 保留最新快照的数量
        /// </summary>
        [JsonProperty("RemainLatestNum")]
        public long? RemainLatestNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "RemainDays", this.RemainDays);
            this.SetParamSimple(map, prefix + "RemainLatestNum", this.RemainLatestNum);
        }
    }
}

