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

namespace TencentCloud.Cdwdoris.V20211228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateInstanceNewRequest : AbstractModel
    {
        
        /// <summary>
        /// 可用区
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// FE规格
        /// </summary>
        [JsonProperty("FeSpec")]
        public CreateInstanceSpec FeSpec{ get; set; }

        /// <summary>
        /// BE规格
        /// </summary>
        [JsonProperty("BeSpec")]
        public CreateInstanceSpec BeSpec{ get; set; }

        /// <summary>
        /// 是否高可用
        /// </summary>
        [JsonProperty("HaFlag")]
        public bool? HaFlag{ get; set; }

        /// <summary>
        /// 用户VPCID
        /// </summary>
        [JsonProperty("UserVPCId")]
        public string UserVPCId{ get; set; }

        /// <summary>
        /// 用户子网ID
        /// </summary>
        [JsonProperty("UserSubnetId")]
        public string UserSubnetId{ get; set; }

        /// <summary>
        /// 产品版本号
        /// </summary>
        [JsonProperty("ProductVersion")]
        public string ProductVersion{ get; set; }

        /// <summary>
        /// 付费类型
        /// </summary>
        [JsonProperty("ChargeProperties")]
        public ChargeProperties ChargeProperties{ get; set; }

        /// <summary>
        /// 实例名字
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 数据库密码
        /// </summary>
        [JsonProperty("DorisUserPwd")]
        public string DorisUserPwd{ get; set; }

        /// <summary>
        /// 标签列表
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 高可用类型：
        /// 0：非高可用（只有1个FE，FeSpec.CreateInstanceSpec.Count=1），
        /// 1：读高可用（至少需部署3个FE，FeSpec.CreateInstanceSpec.Count>=3，且为奇数），
        /// 2：读写高可用（至少需部署5个FE，FeSpec.CreateInstanceSpec.Count>=5，且为奇数）。
        /// </summary>
        [JsonProperty("HaType")]
        public long? HaType{ get; set; }

        /// <summary>
        /// 表名大小写是否敏感，0：敏感；1：不敏感，以小写进行比较；2：不敏感，表名改为以小写存储
        /// </summary>
        [JsonProperty("CaseSensitive")]
        public long? CaseSensitive{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamObj(map, prefix + "FeSpec.", this.FeSpec);
            this.SetParamObj(map, prefix + "BeSpec.", this.BeSpec);
            this.SetParamSimple(map, prefix + "HaFlag", this.HaFlag);
            this.SetParamSimple(map, prefix + "UserVPCId", this.UserVPCId);
            this.SetParamSimple(map, prefix + "UserSubnetId", this.UserSubnetId);
            this.SetParamSimple(map, prefix + "ProductVersion", this.ProductVersion);
            this.SetParamObj(map, prefix + "ChargeProperties.", this.ChargeProperties);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "DorisUserPwd", this.DorisUserPwd);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "HaType", this.HaType);
            this.SetParamSimple(map, prefix + "CaseSensitive", this.CaseSensitive);
        }
    }
}

