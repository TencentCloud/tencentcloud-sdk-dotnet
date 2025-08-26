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

namespace TencentCloud.Dcdb.V20180411.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeProcessListRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 节点ID。
        /// </summary>
        [JsonProperty("NodeId")]
        public string NodeId{ get; set; }

        /// <summary>
        /// 分片ID，与ShardSerialId设置一个。
        /// </summary>
        [JsonProperty("ShardId")]
        public string ShardId{ get; set; }

        /// <summary>
        /// 分片序列ID，与ShardId设置一个。
        /// </summary>
        [JsonProperty("ShardSerialId")]
        public string ShardSerialId{ get; set; }

        /// <summary>
        /// <li><strong>id</strong></li>
        ///     <p style="padding-left: 30px;">按照【<strong>会话ID</strong>】进行过滤。会话ID例如：125700。</p>
        ///     <p style="padding-left: 30px;">类型：String</p>
        ///     <p style="padding-left: 30px;">必选：否</p>
        ///     <p style="padding-left: 30px;">匹配类型：精确匹配</p>
        /// 
        /// <li><strong>user</strong></li>
        ///     <p style="padding-left: 30px;">按照【<strong>用户名</strong>】进行过滤。用户名例如：root。</p>
        ///     <p style="padding-left: 30px;">类型：String</p>
        ///     <p style="padding-left: 30px;">必选：否</p>
        ///     <p style="padding-left: 30px;">匹配类型：精确匹配</p>
        /// <li><strong>host</strong></li>
        ///     <p style="padding-left: 30px;">按照【<strong>客户端Host</strong>】进行过滤。客户端Host例如：127.0.0.1:46295。</p>
        ///     <p style="padding-left: 30px;">类型：String</p>
        ///     <p style="padding-left: 30px;">必选：否</p>
        ///     <p style="padding-left: 30px;">匹配类型：前缀匹配，例如可以查询客户端IP不加端口：127.0.0.1。</p>
        /// <li><strong>state</strong></li>
        ///     <p style="padding-left: 30px;">按照【<strong>线程状态</strong>】进行过滤。线程状态例如：Updating。</p>
        ///     <p style="padding-left: 30px;">类型：String</p>
        ///     <p style="padding-left: 30px;">必选：否</p>
        ///     <p style="padding-left: 30px;">匹配类型：精确匹配</p>
        /// <li><strong>db</strong></li>
        ///     <p style="padding-left: 30px;">按照【<strong>数据库名称</strong>】进行过滤。数据库名称例如：mysql。</p>
        ///     <p style="padding-left: 30px;">类型：String</p>
        ///     <p style="padding-left: 30px;">必选：否</p>
        ///     <p style="padding-left: 30px;">匹配类型：精确匹配</p>
        /// <li><strong>command</strong></li>
        ///     <p style="padding-left: 30px;">按照【<strong>命令类型</strong>】进行过滤。命令类型例如：Query。</p>
        ///     <p style="padding-left: 30px;">类型：String</p>
        ///     <p style="padding-left: 30px;">必选：否</p>
        ///     <p style="padding-left: 30px;">匹配类型：精确匹配</p>
        /// <li><strong>info</strong></li>
        ///     <p style="padding-left: 30px;">按照【<strong>执行语句</strong>】进行过滤。执行语句例如：select id, name from demo.table1 where id > 10。</p>
        ///     <p style="padding-left: 30px;">类型：String</p>
        ///     <p style="padding-left: 30px;">必选：否</p>
        ///     <p style="padding-left: 30px;">匹配类型：前缀匹配，例如SQL较长，可以输入SQL前缀：select  id, name from demo.table1。</p>
        /// <li><strong>time</strong></li>
        ///     <p style="padding-left: 30px;">按照【<strong>执行时间大于多少（秒）</strong>】进行过滤。例如：10，表示查询执行时间超过10秒的会话。</p>
        ///     <p style="padding-left: 30px;">类型：Integer</p>
        ///     <p style="padding-left: 30px;">必选：否</p>
        ///     <p style="padding-left: 30px;">匹配类型：范围匹配，Values值只支持输入1个。</p>
        /// 每次请求的`Filters`的上限为10，`Filter.Values`的上限为50。
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 偏移量，默认为0。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 返回数量，默认为20，最大值为100。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "NodeId", this.NodeId);
            this.SetParamSimple(map, prefix + "ShardId", this.ShardId);
            this.SetParamSimple(map, prefix + "ShardSerialId", this.ShardSerialId);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

