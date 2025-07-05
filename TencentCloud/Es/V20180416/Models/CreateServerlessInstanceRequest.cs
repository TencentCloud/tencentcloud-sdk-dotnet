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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateServerlessInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// 索引名，需以-AppId结尾
        /// </summary>
        [JsonProperty("IndexName")]
        public string IndexName{ get; set; }

        /// <summary>
        /// 可用区
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 私有网络ID
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 子网ID
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 创建的索引元数据JSON，如mappings、settings
        /// </summary>
        [JsonProperty("IndexMetaJson")]
        public string IndexMetaJson{ get; set; }

        /// <summary>
        /// 创建索引的空间ID
        /// </summary>
        [JsonProperty("SpaceId")]
        public string SpaceId{ get; set; }

        /// <summary>
        /// 创建索引的用户名
        /// </summary>
        [JsonProperty("Username")]
        public string Username{ get; set; }

        /// <summary>
        /// 创建索引的密码
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// 创建数据接入
        /// </summary>
        [JsonProperty("ServerlessDi")]
        public ServerlessDi ServerlessDi{ get; set; }

        /// <summary>
        /// 是否自行添加白名单ip
        /// </summary>
        [JsonProperty("AutoGetIp")]
        public ulong? AutoGetIp{ get; set; }

        /// <summary>
        /// 标签信息
        /// </summary>
        [JsonProperty("TagList")]
        public TagInfo[] TagList{ get; set; }

        /// <summary>
        /// kibana公网白名单
        /// </summary>
        [JsonProperty("KibanaWhiteIpList")]
        public string[] KibanaWhiteIpList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IndexName", this.IndexName);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "IndexMetaJson", this.IndexMetaJson);
            this.SetParamSimple(map, prefix + "SpaceId", this.SpaceId);
            this.SetParamSimple(map, prefix + "Username", this.Username);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamObj(map, prefix + "ServerlessDi.", this.ServerlessDi);
            this.SetParamSimple(map, prefix + "AutoGetIp", this.AutoGetIp);
            this.SetParamArrayObj(map, prefix + "TagList.", this.TagList);
            this.SetParamArraySimple(map, prefix + "KibanaWhiteIpList.", this.KibanaWhiteIpList);
        }
    }
}

