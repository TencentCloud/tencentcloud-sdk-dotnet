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

    public class ParamTpl : AbstractModel
    {
        
        /// <summary>
        /// 参数模板名称。
        /// </summary>
        [JsonProperty("TplName")]
        public string TplName{ get; set; }

        /// <summary>
        /// 参数模板 ID。
        /// </summary>
        [JsonProperty("TplId")]
        public string TplId{ get; set; }

        /// <summary>
        /// 参数模板适用的数据库版本。
        /// - MONGO_36_WT：MongoDB 3.6 WiredTiger存储引擎版本，
        /// - MONGO_40_WT：MongoDB 4.0 WiredTiger存储引擎版本，
        /// - MONGO_42_WT：MongoDB 4.2 WiredTiger存储引擎版本。
        /// - MONGO_44_WT：MongoDB 4.4 WiredTiger存储引擎版本。
        /// - MONGO_50_WT：MongoDB 5.0 WiredTiger存储引擎版本。
        /// - MONGO_60_WT：MongoDB 6.0 WiredTiger存储引擎版本。
        /// - MONGO_70_WT：MongoDB 7.0 WiredTiger存储引擎版本。
        /// - MONGO_80_WT：MongoDB 8.0 WiredTiger存储引擎版本。
        /// </summary>
        [JsonProperty("MongoVersion")]
        public string MongoVersion{ get; set; }

        /// <summary>
        /// 参数模板适用的数据库类型。
        /// - REPLSET：副本集实例。
        /// - SHARD：分片实例。
        /// - STANDALONE：单节点实例。
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// 参数模板描述。
        /// </summary>
        [JsonProperty("TplDesc")]
        public string TplDesc{ get; set; }

        /// <summary>
        /// 模板类型。
        /// - DEFAULT：系统默认模板。
        /// - CUSTOMIZE：自定义模板。
        /// </summary>
        [JsonProperty("TplType")]
        public string TplType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TplName", this.TplName);
            this.SetParamSimple(map, prefix + "TplId", this.TplId);
            this.SetParamSimple(map, prefix + "MongoVersion", this.MongoVersion);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "TplDesc", this.TplDesc);
            this.SetParamSimple(map, prefix + "TplType", this.TplType);
        }
    }
}

