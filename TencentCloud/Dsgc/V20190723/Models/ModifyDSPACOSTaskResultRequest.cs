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

namespace TencentCloud.Dsgc.V20190723.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDSPACOSTaskResultRequest : AbstractModel
    {
        
        /// <summary>
        /// DSPA实例ID
        /// </summary>
        [JsonProperty("DspaId")]
        public string DspaId{ get; set; }

        /// <summary>
        /// 合规组ID
        /// </summary>
        [JsonProperty("ComplianceId")]
        public long? ComplianceId{ get; set; }

        /// <summary>
        /// 文件扫描结果ID
        /// </summary>
        [JsonProperty("FileResultId")]
        public long? FileResultId{ get; set; }

        /// <summary>
        /// 是否设置为非敏感文件
        /// </summary>
        [JsonProperty("IsSetNonSensitiveFile")]
        public bool? IsSetNonSensitiveFile{ get; set; }

        /// <summary>
        /// 文件名
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// 桶名
        /// </summary>
        [JsonProperty("BucketName")]
        public string BucketName{ get; set; }

        /// <summary>
        /// 数据源id
        /// </summary>
        [JsonProperty("DataSourceId")]
        public string DataSourceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DspaId", this.DspaId);
            this.SetParamSimple(map, prefix + "ComplianceId", this.ComplianceId);
            this.SetParamSimple(map, prefix + "FileResultId", this.FileResultId);
            this.SetParamSimple(map, prefix + "IsSetNonSensitiveFile", this.IsSetNonSensitiveFile);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "BucketName", this.BucketName);
            this.SetParamSimple(map, prefix + "DataSourceId", this.DataSourceId);
        }
    }
}

