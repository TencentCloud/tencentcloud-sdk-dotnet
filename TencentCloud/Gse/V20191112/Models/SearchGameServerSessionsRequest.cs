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

namespace TencentCloud.Gse.V20191112.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SearchGameServerSessionsRequest : AbstractModel
    {
        
        /// <summary>
        /// 别名ID
        /// </summary>
        [JsonProperty("AliasId")]
        public string AliasId{ get; set; }

        /// <summary>
        /// 舰队ID
        /// </summary>
        [JsonProperty("FleetId")]
        public string FleetId{ get; set; }

        /// <summary>
        /// 单次查询记录数上限
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 页偏移，用于查询下一页，最小长度不小于1个ASCII字符，最大长度不超过1024个ASCII字符
        /// </summary>
        [JsonProperty("NextToken")]
        public string NextToken{ get; set; }

        /// <summary>
        /// 搜索条件表达式，支持如下变量
        /// gameServerSessionName 游戏会话名称 String
        /// gameServerSessionId 游戏会话ID String
        /// maximumSessions 最大的玩家会话数 Number
        /// creationTimeMillis 创建时间，单位：毫秒 Number
        /// playerSessionCount 当前玩家会话数 Number
        /// hasAvailablePlayerSessions 是否有可用玩家数 String 取值true或false
        /// gameServerSessionProperties 游戏会话属性 String
        /// 
        /// 表达式String类型 等于=，不等于<>判断
        /// 表示Number类型支持 =,<>,>,>=,<,<=
        /// 
        /// 例如：
        /// FilterExpression取值
        /// playerSessionCount>=2 AND hasAvailablePlayerSessions=true"
        /// 表示查找至少有两个玩家，而且有可用玩家会话的游戏会话。
        /// FilterExpression取值
        /// gameServerSessionProperties.K1 = 'V1' AND gameServerSessionProperties.K2 = 'V2' OR gameServerSessionProperties.K3 = 'V3'
        /// 
        /// 表示
        /// 查询满足如下游戏服务器会话属性的游戏会话
        /// {
        ///     "GameProperties":[
        ///         {
        ///             "Key":"K1",
        ///             "Value":"V1"
        ///         },
        ///         {
        ///             "Key":"K2",
        ///             "Value":"V2"
        ///         },
        ///         {
        ///             "Key":"K3",
        ///             "Value":"V3"
        ///         }
        ///     ]
        /// }
        /// </summary>
        [JsonProperty("FilterExpression")]
        public string FilterExpression{ get; set; }

        /// <summary>
        /// 排序条件关键字
        /// 支持排序字段
        /// gameServerSessionName 游戏会话名称 String
        /// gameServerSessionId 游戏会话ID String
        /// maximumSessions 最大的玩家会话数 Number
        /// creationTimeMillis 创建时间，单位：毫秒 Number
        /// playerSessionCount 当前玩家会话数 Number
        /// </summary>
        [JsonProperty("SortExpression")]
        public string SortExpression{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AliasId", this.AliasId);
            this.SetParamSimple(map, prefix + "FleetId", this.FleetId);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "NextToken", this.NextToken);
            this.SetParamSimple(map, prefix + "FilterExpression", this.FilterExpression);
            this.SetParamSimple(map, prefix + "SortExpression", this.SortExpression);
        }
    }
}

