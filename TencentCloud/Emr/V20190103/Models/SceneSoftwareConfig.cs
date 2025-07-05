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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SceneSoftwareConfig : AbstractModel
    {
        
        /// <summary>
        /// 部署的组件列表。不同的EMR产品版本ProductVersion 对应不同可选组件列表，不同产品版本可选组件列表查询：[组件版本](https://cloud.tencent.com/document/product/589/20279) ；
        /// 填写实例值：hive、flink。
        /// </summary>
        [JsonProperty("Software")]
        public string[] Software{ get; set; }

        /// <summary>
        /// 默认Hadoop-Default,[场景查询](https://cloud.tencent.com/document/product/589/14624)场景化取值范围：
        /// Hadoop-Kudu
        /// Hadoop-Zookeeper
        /// Hadoop-Presto
        /// Hadoop-Hbase
        /// Hadoop-Default
        /// </summary>
        [JsonProperty("SceneName")]
        public string SceneName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Software.", this.Software);
            this.SetParamSimple(map, prefix + "SceneName", this.SceneName);
        }
    }
}

