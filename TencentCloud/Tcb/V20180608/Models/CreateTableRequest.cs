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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateTableRequest : AbstractModel
    {
        
        /// <summary>
        /// 数据表名；长度不超过96个字符，可以为英文字母、数字、下划线(_)和短横线(-)的组合，且不能以下划线开头
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// FlexDB实例ID，如：tnt-nl7hjzasw
        /// </summary>
        [JsonProperty("Tag")]
        public string Tag{ get; set; }

        /// <summary>
        /// FlexDB数据库权限信息
        /// </summary>
        [JsonProperty("PermissionInfo")]
        public PermissionInfo PermissionInfo{ get; set; }

        /// <summary>
        /// 云开发环境ID
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// MongoDB连接器配置
        /// </summary>
        [JsonProperty("MongoConnector")]
        public MongoConnector MongoConnector{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "Tag", this.Tag);
            this.SetParamObj(map, prefix + "PermissionInfo.", this.PermissionInfo);
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamObj(map, prefix + "MongoConnector.", this.MongoConnector);
        }
    }
}

