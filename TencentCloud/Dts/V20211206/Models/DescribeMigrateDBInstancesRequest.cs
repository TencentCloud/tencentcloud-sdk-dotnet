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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeMigrateDBInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// 数据库类型，如mysql,redis等
        /// </summary>
        [JsonProperty("DatabaseType")]
        public string DatabaseType{ get; set; }

        /// <summary>
        /// 实例作为迁移的源还是目标,src(表示源)，dst(表示目标)
        /// </summary>
        [JsonProperty("MigrateRole")]
        public string MigrateRole{ get; set; }

        /// <summary>
        /// 云数据库实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 云数据库名称
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 返回数量限制
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 偏移量
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 资源所属账号 为空值或self(表示本账号内资源)、other(表示其他账户资源)
        /// </summary>
        [JsonProperty("AccountMode")]
        public string AccountMode{ get; set; }

        /// <summary>
        /// 临时密钥Id，可通过申请扮演角色临时访问凭证获取临时密钥https://cloud.tencent.com/document/product/1312/48197，其中角色资源RoleArn的定义可参考DTS跨账号迁移文档(https://cloud.tencent.com/document/product/571/54117)第4节中关于角色的定义。
        /// </summary>
        [JsonProperty("TmpSecretId")]
        public string TmpSecretId{ get; set; }

        /// <summary>
        /// 临时密钥Id，可通过申请扮演角色临时访问凭证获取临时密钥https://cloud.tencent.com/document/product/1312/48197，其中角色资源RoleArn的定义可参考DTS跨账号迁移文档(https://cloud.tencent.com/document/product/571/54117)第4节中关于角色的定义。
        /// </summary>
        [JsonProperty("TmpSecretKey")]
        public string TmpSecretKey{ get; set; }

        /// <summary>
        /// 临时密钥Id，可通过申请扮演角色临时访问凭证获取临时密钥https://cloud.tencent.com/document/product/1312/48197，其中角色资源RoleArn的定义可参考DTS跨账号迁移文档(https://cloud.tencent.com/document/product/571/54117)第4节中关于角色的定义。
        /// </summary>
        [JsonProperty("TmpToken")]
        public string TmpToken{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DatabaseType", this.DatabaseType);
            this.SetParamSimple(map, prefix + "MigrateRole", this.MigrateRole);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "AccountMode", this.AccountMode);
            this.SetParamSimple(map, prefix + "TmpSecretId", this.TmpSecretId);
            this.SetParamSimple(map, prefix + "TmpSecretKey", this.TmpSecretKey);
            this.SetParamSimple(map, prefix + "TmpToken", this.TmpToken);
        }
    }
}

