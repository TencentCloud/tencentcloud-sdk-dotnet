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

namespace TencentCloud.Goosefs.V20220519.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UserQuotaInfo : AbstractModel
    {
        
        /// <summary>
        /// 配额id
        /// </summary>
        [JsonProperty("QuotaId")]
        public string QuotaId{ get; set; }

        /// <summary>
        /// 配额类型
        /// </summary>
        [JsonProperty("QuotaType")]
        public string QuotaType{ get; set; }

        /// <summary>
        /// 配额对象名称，对应UID/GID的值
        /// </summary>
        [JsonProperty("QuotaObjectName")]
        public string QuotaObjectName{ get; set; }

        /// <summary>
        /// 容量配额限定值
        /// </summary>
        [JsonProperty("QuotaSizeLimit")]
        public string QuotaSizeLimit{ get; set; }

        /// <summary>
        /// 已使用容量配额
        /// </summary>
        [JsonProperty("QuotaSizeUsed")]
        public string QuotaSizeUsed{ get; set; }

        /// <summary>
        /// 容量配额使用占比
        /// </summary>
        [JsonProperty("QuotaSizeUsedPercent")]
        public string QuotaSizeUsedPercent{ get; set; }

        /// <summary>
        /// 文件数配额限定值
        /// </summary>
        [JsonProperty("QuotaFilesLimit")]
        public string QuotaFilesLimit{ get; set; }

        /// <summary>
        /// 已使用文件数配额
        /// </summary>
        [JsonProperty("QuotaFilesUsed")]
        public string QuotaFilesUsed{ get; set; }

        /// <summary>
        /// 文件数配额使用占比
        /// </summary>
        [JsonProperty("QuotaFilesUsedPercent")]
        public string QuotaFilesUsedPercent{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// 配额状态：creating 配置中 active 已生效 modify 修改中
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "QuotaId", this.QuotaId);
            this.SetParamSimple(map, prefix + "QuotaType", this.QuotaType);
            this.SetParamSimple(map, prefix + "QuotaObjectName", this.QuotaObjectName);
            this.SetParamSimple(map, prefix + "QuotaSizeLimit", this.QuotaSizeLimit);
            this.SetParamSimple(map, prefix + "QuotaSizeUsed", this.QuotaSizeUsed);
            this.SetParamSimple(map, prefix + "QuotaSizeUsedPercent", this.QuotaSizeUsedPercent);
            this.SetParamSimple(map, prefix + "QuotaFilesLimit", this.QuotaFilesLimit);
            this.SetParamSimple(map, prefix + "QuotaFilesUsed", this.QuotaFilesUsed);
            this.SetParamSimple(map, prefix + "QuotaFilesUsedPercent", this.QuotaFilesUsedPercent);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

