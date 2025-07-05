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

    public class CreateSchedulerMailProfileRequest : AbstractModel
    {
        
        /// <summary>
        /// 取值范围1-7，分别代表周一至周日。
        /// </summary>
        [JsonProperty("WeekConfiguration")]
        public long?[] WeekConfiguration{ get; set; }

        /// <summary>
        /// 邮件配置内容。
        /// </summary>
        [JsonProperty("ProfileInfo")]
        public ProfileInfo ProfileInfo{ get; set; }

        /// <summary>
        /// 配置名称，需要保持唯一性，定期生成邮件配置命名格式："scheduler_" + {instanceId}，如"schduler_cdb-test"。
        /// </summary>
        [JsonProperty("ProfileName")]
        public string ProfileName{ get; set; }

        /// <summary>
        /// 配置订阅的实例ID。
        /// </summary>
        [JsonProperty("BindInstanceId")]
        public string BindInstanceId{ get; set; }

        /// <summary>
        /// 服务产品类型，支持值包括： "mysql" - 云数据库 MySQL， "cynosdb" - 云数据库 TDSQL-C for MySQL，默认为"mysql"。
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "WeekConfiguration.", this.WeekConfiguration);
            this.SetParamObj(map, prefix + "ProfileInfo.", this.ProfileInfo);
            this.SetParamSimple(map, prefix + "ProfileName", this.ProfileName);
            this.SetParamSimple(map, prefix + "BindInstanceId", this.BindInstanceId);
            this.SetParamSimple(map, prefix + "Product", this.Product);
        }
    }
}

