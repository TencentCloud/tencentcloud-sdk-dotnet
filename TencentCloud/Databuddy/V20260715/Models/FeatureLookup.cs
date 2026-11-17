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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FeatureLookup : AbstractModel
    {
        
        /// <summary>
        /// 特征表全名
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// 关联键
        /// </summary>
        [JsonProperty("LookupKey")]
        public string[] LookupKey{ get; set; }

        /// <summary>
        /// 时间戳关联键
        /// </summary>
        [JsonProperty("TimestampLookupKey")]
        public string TimestampLookupKey{ get; set; }

        /// <summary>
        /// 特征列名列表
        /// </summary>
        [JsonProperty("FeatureNames")]
        public string[] FeatureNames{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamArraySimple(map, prefix + "LookupKey.", this.LookupKey);
            this.SetParamSimple(map, prefix + "TimestampLookupKey", this.TimestampLookupKey);
            this.SetParamArraySimple(map, prefix + "FeatureNames.", this.FeatureNames);
        }
    }
}

