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

    public class DescribeDBInstanceParamTplRequest : AbstractModel
    {
        
        /// <summary>
        /// 参数模板 ID。请通过接口 [DescribeDBInstanceParamTpl](https://cloud.tencent.com/document/product/240/109155) 获取模板 ID。
        /// </summary>
        [JsonProperty("TplIds")]
        public string[] TplIds{ get; set; }

        /// <summary>
        /// 指定查询的模板名称。
        /// </summary>
        [JsonProperty("TplNames")]
        public string[] TplNames{ get; set; }

        /// <summary>
        /// 指定所需查询的参数模板的数据库版本号。具体支持的版本信息，请通过接口 [DescribeSpecInfo](https://cloud.tencent.com/document/product/240/38567) 获取。
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
        public string[] MongoVersion{ get; set; }

        /// <summary>
        /// 指定查询的模板类型。
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
            this.SetParamArraySimple(map, prefix + "TplIds.", this.TplIds);
            this.SetParamArraySimple(map, prefix + "TplNames.", this.TplNames);
            this.SetParamArraySimple(map, prefix + "MongoVersion.", this.MongoVersion);
            this.SetParamSimple(map, prefix + "TplType", this.TplType);
        }
    }
}

