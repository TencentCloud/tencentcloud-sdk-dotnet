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

namespace TencentCloud.Dbs.V20211108.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateBackupPlanRequest : AbstractModel
    {
        
        /// <summary>
        /// 源端数据库类型。当前支持值为: ["mysql","cynosdbmysql","percona","mariadb","tdsqlmysql"]。
        /// </summary>
        [JsonProperty("DatabaseType")]
        public string DatabaseType{ get; set; }

        /// <summary>
        /// 备份方式。当前仅支持"logical"，即逻辑备份。
        /// </summary>
        [JsonProperty("BackupMethod")]
        public string BackupMethod{ get; set; }

        /// <summary>
        /// 规格。当前支持值为: ["micro","small","medium","large","xlarge"]。默认为"small"。
        /// </summary>
        [JsonProperty("InstanceClass")]
        public string InstanceClass{ get; set; }

        /// <summary>
        /// 购买时长，单位为月，默认值为1。
        /// </summary>
        [JsonProperty("Period")]
        public long? Period{ get; set; }

        /// <summary>
        /// 计费模式。当前仅支持"prepay"，即包年包月。
        /// </summary>
        [JsonProperty("PayType")]
        public string PayType{ get; set; }

        /// <summary>
        /// 购买数量。取值范围为[1, 10]，默认值为1。
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }

        /// <summary>
        /// 自动续费标识。1 - 开启自动续费；0 - 不开启自动续费。
        /// </summary>
        [JsonProperty("AutoRenew")]
        public long? AutoRenew{ get; set; }

        /// <summary>
        /// 标签值。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DatabaseType", this.DatabaseType);
            this.SetParamSimple(map, prefix + "BackupMethod", this.BackupMethod);
            this.SetParamSimple(map, prefix + "InstanceClass", this.InstanceClass);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "PayType", this.PayType);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "AutoRenew", this.AutoRenew);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

