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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImportProjectParamDsRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 已废弃
        /// </summary>
        [JsonProperty("FilesCos")]
        public string[] FilesCos{ get; set; }

        /// <summary>
        /// 发布ID
        /// </summary>
        [JsonProperty("PublishInfoId")]
        public string PublishInfoId{ get; set; }

        /// <summary>
        /// 全局参数
        /// </summary>
        [JsonProperty("GlobalConfig")]
        public string GlobalConfig{ get; set; }

        /// <summary>
        /// 已废弃
        /// </summary>
        [JsonProperty("BucketName")]
        public string BucketName{ get; set; }

        /// <summary>
        /// 已废弃
        /// </summary>
        [JsonProperty("CosRegion")]
        public string CosRegion{ get; set; }

        /// <summary>
        /// 共享存储临时文件名称，详情可以见 UploadFileDs 接口，该参数从 UploadFileDs 中的 TargetFileName
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamArraySimple(map, prefix + "FilesCos.", this.FilesCos);
            this.SetParamSimple(map, prefix + "PublishInfoId", this.PublishInfoId);
            this.SetParamSimple(map, prefix + "GlobalConfig", this.GlobalConfig);
            this.SetParamSimple(map, prefix + "BucketName", this.BucketName);
            this.SetParamSimple(map, prefix + "CosRegion", this.CosRegion);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
        }
    }
}

