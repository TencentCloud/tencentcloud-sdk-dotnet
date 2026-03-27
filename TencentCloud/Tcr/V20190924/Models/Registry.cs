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

namespace TencentCloud.Tcr.V20190924.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Registry : AbstractModel
    {
        
        /// <summary>
        /// <p>实例ID</p>
        /// </summary>
        [JsonProperty("RegistryId")]
        public string RegistryId{ get; set; }

        /// <summary>
        /// <p>实例名称</p>
        /// </summary>
        [JsonProperty("RegistryName")]
        public string RegistryName{ get; set; }

        /// <summary>
        /// <p>实例规格</p>
        /// </summary>
        [JsonProperty("RegistryType")]
        public string RegistryType{ get; set; }

        /// <summary>
        /// <p>实例状态。有以下状态：<br>Pending, 初始化中<br>Deploying, 创建中<br>Running, 运行中<br>Unhealthy, 状态异常<br>FailedCreated, 创建失败<br>FailedUpdated, 更新失败<br>Bucket-Error, 存储桶异常<br>Isolate, 待回收<br>Deleting, 删除中<br>DeleteBucketFailed, 实例删除存储桶失败<br>DeleteFailed, 实例删除失败</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>实例的公共访问地址</p>
        /// </summary>
        [JsonProperty("PublicDomain")]
        public string PublicDomain{ get; set; }

        /// <summary>
        /// <p>实例创建时间</p>
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// <p>地域名称</p>
        /// </summary>
        [JsonProperty("RegionName")]
        public string RegionName{ get; set; }

        /// <summary>
        /// <p>地域Id</p>
        /// </summary>
        [JsonProperty("RegionId")]
        public ulong? RegionId{ get; set; }

        /// <summary>
        /// <p>是否支持匿名</p>
        /// </summary>
        [JsonProperty("EnableAnonymous")]
        public bool? EnableAnonymous{ get; set; }

        /// <summary>
        /// <p>Token有效时间</p>
        /// </summary>
        [JsonProperty("TokenValidTime")]
        public ulong? TokenValidTime{ get; set; }

        /// <summary>
        /// <p>实例内部访问地址</p>
        /// </summary>
        [JsonProperty("InternalEndpoint")]
        public string InternalEndpoint{ get; set; }

        /// <summary>
        /// <p>实例云标签</p>
        /// </summary>
        [JsonProperty("TagSpecification")]
        public TagSpecification TagSpecification{ get; set; }

        /// <summary>
        /// <p>实例过期时间（预付费）</p>
        /// </summary>
        [JsonProperty("ExpiredAt")]
        public string ExpiredAt{ get; set; }

        /// <summary>
        /// <p>实例付费类型，0表示后付费，1表示预付费</p>
        /// </summary>
        [JsonProperty("PayMod")]
        public long? PayMod{ get; set; }

        /// <summary>
        /// <p>预付费续费标识，0表示手动续费，1表示自动续费，2不续费并且不通知</p>
        /// </summary>
        [JsonProperty("RenewFlag")]
        public long? RenewFlag{ get; set; }

        /// <summary>
        /// <p>是否开启实例删除保护，false表示不开启</p>
        /// </summary>
        [JsonProperty("DeletionProtection")]
        public bool? DeletionProtection{ get; set; }

        /// <summary>
        /// <p>是否支持AI特性</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AIFeature")]
        public bool? AIFeature{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RegistryId", this.RegistryId);
            this.SetParamSimple(map, prefix + "RegistryName", this.RegistryName);
            this.SetParamSimple(map, prefix + "RegistryType", this.RegistryType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "PublicDomain", this.PublicDomain);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "RegionName", this.RegionName);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamSimple(map, prefix + "EnableAnonymous", this.EnableAnonymous);
            this.SetParamSimple(map, prefix + "TokenValidTime", this.TokenValidTime);
            this.SetParamSimple(map, prefix + "InternalEndpoint", this.InternalEndpoint);
            this.SetParamObj(map, prefix + "TagSpecification.", this.TagSpecification);
            this.SetParamSimple(map, prefix + "ExpiredAt", this.ExpiredAt);
            this.SetParamSimple(map, prefix + "PayMod", this.PayMod);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "DeletionProtection", this.DeletionProtection);
            this.SetParamSimple(map, prefix + "AIFeature", this.AIFeature);
        }
    }
}

