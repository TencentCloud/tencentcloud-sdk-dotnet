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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExportImagesRequest : AbstractModel
    {
        
        /// <summary>
        /// COS存储桶名称。
        /// 可通过 [List Buckets](https://cloud.tencent.com/document/product/436/8291) 接口查询请求者名下的所有存储桶列表或特定地域下的存储桶列表。
        /// </summary>
        [JsonProperty("BucketName")]
        public string BucketName{ get; set; }

        /// <summary>
        /// 镜像ID列表。调用 ExportImages 接口时，参数 ImageIds 和 SnapshotIds 为二选一必填参数，目前参数 SnapshotIds 暂未对外开放。
        /// 可通过 [DescribeImages](https://cloud.tencent.com/document/api/213/15715) 接口返回值中的`ImageId`获取。
        /// </summary>
        [JsonProperty("ImageIds")]
        public string[] ImageIds{ get; set; }

        /// <summary>
        /// 镜像文件导出格式。取值范围：RAW，QCOW2，VHD，VMDK。默认为RAW
        /// </summary>
        [JsonProperty("ExportFormat")]
        public string ExportFormat{ get; set; }

        /// <summary>
        /// 导出文件的名称前缀列表。
        /// 默认导出文件无名称前缀。
        /// </summary>
        [JsonProperty("FileNamePrefixList")]
        public string[] FileNamePrefixList{ get; set; }

        /// <summary>
        /// 是否只导出系统盘。
        /// 默认值：false
        /// </summary>
        [JsonProperty("OnlyExportRootDisk")]
        public bool? OnlyExportRootDisk{ get; set; }

        /// <summary>
        /// 检测镜像是否支持导出。
        /// 默认值：false
        /// </summary>
        [JsonProperty("DryRun")]
        public bool? DryRun{ get; set; }

        /// <summary>
        /// 角色名称。默认为CVM_QcsRole，发起请求前请确认是否存在该角色，以及是否已正确配置COS写入权限。
        /// </summary>
        [JsonProperty("RoleName")]
        public string RoleName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BucketName", this.BucketName);
            this.SetParamArraySimple(map, prefix + "ImageIds.", this.ImageIds);
            this.SetParamSimple(map, prefix + "ExportFormat", this.ExportFormat);
            this.SetParamArraySimple(map, prefix + "FileNamePrefixList.", this.FileNamePrefixList);
            this.SetParamSimple(map, prefix + "OnlyExportRootDisk", this.OnlyExportRootDisk);
            this.SetParamSimple(map, prefix + "DryRun", this.DryRun);
            this.SetParamSimple(map, prefix + "RoleName", this.RoleName);
        }
    }
}

