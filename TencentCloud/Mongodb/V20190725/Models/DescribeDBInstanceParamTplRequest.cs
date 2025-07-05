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
        /// 参数模板 ID 查询条件。
        /// </summary>
        [JsonProperty("TplIds")]
        public string[] TplIds{ get; set; }

        /// <summary>
        /// 模板名称，查询条件。
        /// </summary>
        [JsonProperty("TplNames")]
        public string[] TplNames{ get; set; }

        /// <summary>
        /// 根据版本号查询参数模板，具体支持的售卖版本，请参见[DescribeSpecInfo](https://cloud.tencent.com/document/product/240/38567)查询云数据库的售卖规格的返回结果。参数与版本对应关系如下所示：
        /// - MONGO_36_WT：MongoDB 3.6 WiredTiger存储引擎版本。
        /// - MONGO_40_WT：MongoDB 4.0 WiredTiger存储引擎版本。
        /// - MONGO_42_WT：MongoDB 4.2 WiredTiger存储引擎版本。
        /// </summary>
        [JsonProperty("MongoVersion")]
        public string[] MongoVersion{ get; set; }

        /// <summary>
        /// 根据模板类型查询参数模板，支持DEFAULT（默认模板）和CUSTOMIZE（自定义模板）两种。
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

