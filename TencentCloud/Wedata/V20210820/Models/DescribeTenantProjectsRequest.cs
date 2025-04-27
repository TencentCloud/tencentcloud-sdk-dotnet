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

    public class DescribeTenantProjectsRequest : AbstractModel
    {
        
        /// <summary>
        /// 第几页
        /// </summary>
        [JsonProperty("PageNumber")]
        public ulong? PageNumber{ get; set; }

        /// <summary>
        /// 一页几条
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// 是否展示关联执行组的信息。正常应该不是从项目列表里获取
        /// </summary>
        [JsonProperty("DescribeExecutors")]
        public bool? DescribeExecutors{ get; set; }

        /// <summary>
        /// 是否展示项目管理员信息，减少默认返回的请求内容
        /// </summary>
        [JsonProperty("DescribeAdminUsers")]
        public bool? DescribeAdminUsers{ get; set; }

        /// <summary>
        /// 统计项目人员数量。数据地图需求
        /// </summary>
        [JsonProperty("DescribeMemberCount")]
        public bool? DescribeMemberCount{ get; set; }

        /// <summary>
        /// 自定义条件查询
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 排序字段
        /// </summary>
        [JsonProperty("OrderFields")]
        public OrderField[] OrderFields{ get; set; }

        /// <summary>
        /// 默认不提供创建者信息，该参数与CAM交互比较耗时
        /// </summary>
        [JsonProperty("DescribeCreator")]
        public bool? DescribeCreator{ get; set; }

        /// <summary>
        /// 是否展示关联资源池信息
        /// </summary>
        [JsonProperty("DescribeResourcePools")]
        public bool? DescribeResourcePools{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "DescribeExecutors", this.DescribeExecutors);
            this.SetParamSimple(map, prefix + "DescribeAdminUsers", this.DescribeAdminUsers);
            this.SetParamSimple(map, prefix + "DescribeMemberCount", this.DescribeMemberCount);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamArrayObj(map, prefix + "OrderFields.", this.OrderFields);
            this.SetParamSimple(map, prefix + "DescribeCreator", this.DescribeCreator);
            this.SetParamSimple(map, prefix + "DescribeResourcePools", this.DescribeResourcePools);
        }
    }
}

