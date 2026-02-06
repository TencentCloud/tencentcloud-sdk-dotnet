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

    public class UpgradeDbInstanceVersionRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例ID列表，格式如：cmgo-p8vnipr5。与云数据库控制台页面中显示的实例ID相同。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 新升级的数据库版本。当前支持版本如下所示，支持旧版本向高版本升级，不支持跨版本升级。
        /// - MONGO_40_WT：4.0 版本。
        /// - MONGO_42_WT：4.2 版本。
        /// - MONGO_44_WT：4.4 版本
        /// - MONGO_50_WT：5.0 版本
        /// - MONGO_60_WT：6.0 版本。
        /// - MONGO_70_WT：7.0 版本。
        /// - MONGO_80_WT：8.0 版本。
        /// </summary>
        [JsonProperty("MongoVersion")]
        public string MongoVersion{ get; set; }

        /// <summary>
        /// 指定升级操作是否在维护时间内进行。
        /// - 0：立即升级。
        /// - 1：维护时间窗升级。
        /// </summary>
        [JsonProperty("InMaintenance")]
        public long? InMaintenance{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "MongoVersion", this.MongoVersion);
            this.SetParamSimple(map, prefix + "InMaintenance", this.InMaintenance);
        }
    }
}

