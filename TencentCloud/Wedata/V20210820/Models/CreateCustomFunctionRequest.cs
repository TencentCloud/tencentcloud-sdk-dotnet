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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCustomFunctionRequest : AbstractModel
    {
        
        /// <summary>
        /// 类型：HIVE、SPARK
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 分类：窗口函数、聚合函数、日期函数......
        /// </summary>
        [JsonProperty("Kind")]
        public string Kind{ get; set; }

        /// <summary>
        /// 函数名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 集群实例引擎 ID
        /// </summary>
        [JsonProperty("ClusterIdentifier")]
        public string ClusterIdentifier{ get; set; }

        /// <summary>
        /// 数据库名称
        /// </summary>
        [JsonProperty("DbName")]
        public string DbName{ get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Kind", this.Kind);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ClusterIdentifier", this.ClusterIdentifier);
            this.SetParamSimple(map, prefix + "DbName", this.DbName);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
        }
    }
}

