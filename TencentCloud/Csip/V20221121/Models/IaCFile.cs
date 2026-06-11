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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IaCFile : AbstractModel
    {
        
        /// <summary>
        /// <p>ID</p>
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// <p>appid</p>
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// <p>文件ID</p>
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// <p>文件名称</p>
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// <p>CI/CD名称</p>
        /// </summary>
        [JsonProperty("CICDName")]
        public string CICDName{ get; set; }

        /// <summary>
        /// <p>文件路径</p>
        /// </summary>
        [JsonProperty("FilePath")]
        public string FilePath{ get; set; }

        /// <summary>
        /// <p>文件类型(1:Dockerfile,2:Terraform,3:KubernetesYaml)</p>
        /// </summary>
        [JsonProperty("FileType")]
        public long? FileType{ get; set; }

        /// <summary>
        /// <p>风险总计数量</p>
        /// </summary>
        [JsonProperty("RiskTotalCnt")]
        public ulong? RiskTotalCnt{ get; set; }

        /// <summary>
        /// <p>风险等级数量(0:低危,1:中危,2:高危,3:严重)</p>
        /// </summary>
        [JsonProperty("RiskLevelCnt")]
        public KeyValueInt[] RiskLevelCnt{ get; set; }

        /// <summary>
        /// <p>扫描时间</p>
        /// </summary>
        [JsonProperty("ScanTime")]
        public string ScanTime{ get; set; }

        /// <summary>
        /// <p>检测状态(0:待扫描,1:检测中,2:已完成,3:检测异常)</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>扫描失败类型(0:无失败, 1:检测超时, 2:文件格式解析失败, 3:检测失败)</p>
        /// </summary>
        [JsonProperty("FailType")]
        public long? FailType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "CICDName", this.CICDName);
            this.SetParamSimple(map, prefix + "FilePath", this.FilePath);
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamSimple(map, prefix + "RiskTotalCnt", this.RiskTotalCnt);
            this.SetParamArrayObj(map, prefix + "RiskLevelCnt.", this.RiskLevelCnt);
            this.SetParamSimple(map, prefix + "ScanTime", this.ScanTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "FailType", this.FailType);
        }
    }
}

