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

namespace TencentCloud.Dasb.V20191018.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeUsersRequest : AbstractModel
    {
        
        /// <summary>
        /// 如果IdSet不为空，则忽略其他参数
        /// </summary>
        [JsonProperty("IdSet")]
        public ulong?[] IdSet{ get; set; }

        /// <summary>
        /// 模糊查询，IdSet、UserName、Phone为空时才生效，对用户名和姓名进行模糊查询
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 分页，偏移位置
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 每页条目数量，默认20
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 精确查询，IdSet为空时才生效
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 精确查询，IdSet、UserName为空时才生效
        /// </summary>
        [JsonProperty("Phone")]
        public string Phone{ get; set; }

        /// <summary>
        /// 有访问权限的主机ID集合
        /// </summary>
        [JsonProperty("AuthorizedDeviceIdSet")]
        public ulong?[] AuthorizedDeviceIdSet{ get; set; }

        /// <summary>
        /// 认证方式，0-本地，1-ldap, 2-oauth 不传为全部
        /// </summary>
        [JsonProperty("AuthTypeSet")]
        public ulong?[] AuthTypeSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "IdSet.", this.IdSet);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "Phone", this.Phone);
            this.SetParamArraySimple(map, prefix + "AuthorizedDeviceIdSet.", this.AuthorizedDeviceIdSet);
            this.SetParamArraySimple(map, prefix + "AuthTypeSet.", this.AuthTypeSet);
        }
    }
}

