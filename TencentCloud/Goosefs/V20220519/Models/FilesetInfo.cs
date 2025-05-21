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

namespace TencentCloud.Goosefs.V20220519.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FilesetInfo : AbstractModel
    {
        
        /// <summary>
        /// Fileset id
        /// </summary>
        [JsonProperty("FsetId")]
        public string FsetId{ get; set; }

        /// <summary>
        /// Fileset名称
        /// </summary>
        [JsonProperty("FsetName")]
        public string FsetName{ get; set; }

        /// <summary>
        /// Fileset目录
        /// </summary>
        [JsonProperty("FsetDir")]
        public string FsetDir{ get; set; }

        /// <summary>
        /// Fileset容量配额限定值
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
        /// Fileset文件数配额限定值
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
        /// Fileset审计
        /// </summary>
        [JsonProperty("AuditState")]
        public string AuditState{ get; set; }

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
        /// Fileset状态：creating 配置中 active 已生效 modify 修改中
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FsetId", this.FsetId);
            this.SetParamSimple(map, prefix + "FsetName", this.FsetName);
            this.SetParamSimple(map, prefix + "FsetDir", this.FsetDir);
            this.SetParamSimple(map, prefix + "QuotaSizeLimit", this.QuotaSizeLimit);
            this.SetParamSimple(map, prefix + "QuotaSizeUsed", this.QuotaSizeUsed);
            this.SetParamSimple(map, prefix + "QuotaSizeUsedPercent", this.QuotaSizeUsedPercent);
            this.SetParamSimple(map, prefix + "QuotaFilesLimit", this.QuotaFilesLimit);
            this.SetParamSimple(map, prefix + "QuotaFilesUsed", this.QuotaFilesUsed);
            this.SetParamSimple(map, prefix + "QuotaFilesUsedPercent", this.QuotaFilesUsedPercent);
            this.SetParamSimple(map, prefix + "AuditState", this.AuditState);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

