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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateResourceFileRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 资源文件名称, 尽可能和上传文件名保持一致
        /// </summary>
        [JsonProperty("ResourceName")]
        public string ResourceName{ get; set; }

        /// <summary>
        /// cos存储桶名称, 可从GetResourceCosPath接口获取
        /// </summary>
        [JsonProperty("BucketName")]
        public string BucketName{ get; set; }

        /// <summary>
        /// BucketName桶对应的cos存储桶区域
        /// </summary>
        [JsonProperty("CosRegion")]
        public string CosRegion{ get; set; }

        /// <summary>
        /// 项目中资源文件上传的路径, 取值示例: /wedata/qxxxm/, 根目录,请使用/即可
        /// </summary>
        [JsonProperty("ParentFolderPath")]
        public string ParentFolderPath{ get; set; }

        /// <summary>
        /// - 上传文件及手填两种方式只能选择其一，如果两者均提供，取值顺序为文件>手填值
        /// -   手填值必须是存在的cos路径, parentFolderPath为父文件夹路径, name为文件名, 手填值取值示例:     /datastudio/resource/projectId/parentFolderPath/name 
        /// </summary>
        [JsonProperty("ResourceFile")]
        public string ResourceFile{ get; set; }

        /// <summary>
        /// bundle客户端ID
        /// </summary>
        [JsonProperty("BundleId")]
        public string BundleId{ get; set; }

        /// <summary>
        /// bundle客户端信息
        /// </summary>
        [JsonProperty("BundleInfo")]
        public string BundleInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ResourceName", this.ResourceName);
            this.SetParamSimple(map, prefix + "BucketName", this.BucketName);
            this.SetParamSimple(map, prefix + "CosRegion", this.CosRegion);
            this.SetParamSimple(map, prefix + "ParentFolderPath", this.ParentFolderPath);
            this.SetParamSimple(map, prefix + "ResourceFile", this.ResourceFile);
            this.SetParamSimple(map, prefix + "BundleId", this.BundleId);
            this.SetParamSimple(map, prefix + "BundleInfo", this.BundleInfo);
        }
    }
}

