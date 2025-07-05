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

namespace TencentCloud.Dbbrain.V20191016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateMailProfileRequest : AbstractModel
    {
        
        /// <summary>
        /// 邮件配置内容。
        /// </summary>
        [JsonProperty("ProfileInfo")]
        public ProfileInfo ProfileInfo{ get; set; }

        /// <summary>
        /// 配置级别，支持值包括："User" - 用户级别，"Instance" - 实例级别，其中数据库巡检邮件配置为用户级别，定期生成邮件配置为实例级别。
        /// </summary>
        [JsonProperty("ProfileLevel")]
        public string ProfileLevel{ get; set; }

        /// <summary>
        /// 配置名称，需要保持唯一性，数据库巡检邮件配置名称自拟；定期生成邮件配置命名格式："scheduler_" + {instanceId}，如"schduler_cdb-test"。
        /// </summary>
        [JsonProperty("ProfileName")]
        public string ProfileName{ get; set; }

        /// <summary>
        /// 配置类型，支持值包括："dbScan_mail_configuration" - 数据库巡检邮件配置，"scheduler_mail_configuration" - 定期生成邮件配置。
        /// </summary>
        [JsonProperty("ProfileType")]
        public string ProfileType{ get; set; }

        /// <summary>
        /// 服务产品类型，支持值包括： "mysql" - 云数据库 MySQL， "cynosdb" - 云数据库 CynosDB  for MySQL。
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }

        /// <summary>
        /// 配置绑定的实例ID，当配置级别为"Instance"时需要传入且只能为一个实例；当配置级别为“User”时，此参数不填。
        /// </summary>
        [JsonProperty("BindInstanceIds")]
        public string[] BindInstanceIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ProfileInfo.", this.ProfileInfo);
            this.SetParamSimple(map, prefix + "ProfileLevel", this.ProfileLevel);
            this.SetParamSimple(map, prefix + "ProfileName", this.ProfileName);
            this.SetParamSimple(map, prefix + "ProfileType", this.ProfileType);
            this.SetParamSimple(map, prefix + "Product", this.Product);
            this.SetParamArraySimple(map, prefix + "BindInstanceIds.", this.BindInstanceIds);
        }
    }
}

