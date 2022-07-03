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

    public class DescribeProjectRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目id。一般使用项目Id来查询，与projectName必须存在一个。
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 是否展示关联集群信息
        /// </summary>
        [JsonProperty("DescribeClusters")]
        public bool? DescribeClusters{ get; set; }

        /// <summary>
        /// 是否展示关联执行组的信息，仅部分信息。
        /// </summary>
        [JsonProperty("DescribeExecutors")]
        public bool? DescribeExecutors{ get; set; }

        /// <summary>
        /// 默认不展示项目管理员信息
        /// </summary>
        [JsonProperty("DescribeAdminUsers")]
        public bool? DescribeAdminUsers{ get; set; }

        /// <summary>
        /// 默认不统计项目人员数量
        /// </summary>
        [JsonProperty("DescribeMemberCount")]
        public bool? DescribeMemberCount{ get; set; }

        /// <summary>
        /// 默认不查询创建者的信息
        /// </summary>
        [JsonProperty("DescribeCreator")]
        public bool? DescribeCreator{ get; set; }

        /// <summary>
        /// 项目名只在租户内唯一，一般用来转化为项目ID。
        /// </summary>
        [JsonProperty("ProjectName")]
        public string ProjectName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "DescribeClusters", this.DescribeClusters);
            this.SetParamSimple(map, prefix + "DescribeExecutors", this.DescribeExecutors);
            this.SetParamSimple(map, prefix + "DescribeAdminUsers", this.DescribeAdminUsers);
            this.SetParamSimple(map, prefix + "DescribeMemberCount", this.DescribeMemberCount);
            this.SetParamSimple(map, prefix + "DescribeCreator", this.DescribeCreator);
            this.SetParamSimple(map, prefix + "ProjectName", this.ProjectName);
        }
    }
}

