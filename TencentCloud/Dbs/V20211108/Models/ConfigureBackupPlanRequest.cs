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

    public class ConfigureBackupPlanRequest : AbstractModel
    {
        
        /// <summary>
        /// 备份计划 ID。
        /// </summary>
        [JsonProperty("BackupPlanId")]
        public string BackupPlanId{ get; set; }

        /// <summary>
        /// 备份计划名称。支持数字、英文大小写字母、中文以及特殊字符_-./()（）[]+=：:@,且长度不能超过60。
        /// </summary>
        [JsonProperty("BackupPlanName")]
        public string BackupPlanName{ get; set; }

        /// <summary>
        /// 备份源实例信息。
        /// </summary>
        [JsonProperty("SourceEndPoint")]
        public BackupEndpoint SourceEndPoint{ get; set; }

        /// <summary>
        /// 备份对象信息。
        /// </summary>
        [JsonProperty("BackupObject")]
        public BackupObject BackupObject{ get; set; }

        /// <summary>
        /// 备份策略。
        /// </summary>
        [JsonProperty("BackupStrategy")]
        public BackupStrategy BackupStrategy{ get; set; }

        /// <summary>
        /// 加密信息。当需要使用SSE-KMS需要传入该值，你可以通过 KMS 的 GenerateDataKey 接口生成。
        /// </summary>
        [JsonProperty("PlainText")]
        public string PlainText{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BackupPlanId", this.BackupPlanId);
            this.SetParamSimple(map, prefix + "BackupPlanName", this.BackupPlanName);
            this.SetParamObj(map, prefix + "SourceEndPoint.", this.SourceEndPoint);
            this.SetParamObj(map, prefix + "BackupObject.", this.BackupObject);
            this.SetParamObj(map, prefix + "BackupStrategy.", this.BackupStrategy);
            this.SetParamSimple(map, prefix + "PlainText", this.PlainText);
        }
    }
}

