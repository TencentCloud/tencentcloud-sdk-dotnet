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

    public class ImportImageRequest : AbstractModel
    {
        
        /// <summary>
        /// 导入镜像的操作系统架构。
        /// 取值范围包括：`x86_64` 、`i386`、`arm_64`
        /// </summary>
        [JsonProperty("Architecture")]
        public string Architecture{ get; set; }

        /// <summary>
        /// 导入镜像的操作系统类型 。
        /// 可通过 [DescribeImportImageOs](https://cloud.tencent.com/document/api/213/15718) 接口返回值中的`ImportImageOsListSupported`获取。
        /// </summary>
        [JsonProperty("OsType")]
        public string OsType{ get; set; }

        /// <summary>
        /// 导入镜像的操作系统版本。
        /// 可通过 [DescribeImportImageOs](https://cloud.tencent.com/document/api/213/15718) 接口返回值中的`ImportImageOsVersionSet`获取。
        /// </summary>
        [JsonProperty("OsVersion")]
        public string OsVersion{ get; set; }

        /// <summary>
        /// 导入镜像存放的cos地址
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// 镜像名称。
        /// 最多支持 60 个字符。
        /// </summary>
        [JsonProperty("ImageName")]
        public string ImageName{ get; set; }

        /// <summary>
        /// 镜像描述。
        /// 最多支持 256 个字符。
        /// </summary>
        [JsonProperty("ImageDescription")]
        public string ImageDescription{ get; set; }

        /// <summary>
        /// 只检查参数，不执行任务。
        /// 默认值：false
        /// </summary>
        [JsonProperty("DryRun")]
        public bool? DryRun{ get; set; }

        /// <summary>
        /// 是否强制导入，参考[强制导入镜像](https://cloud.tencent.com/document/product/213/12849)
        /// 默认值：false
        /// </summary>
        [JsonProperty("Force")]
        public bool? Force{ get; set; }

        /// <summary>
        /// 标签描述列表。通过指定该参数可以同时绑定标签到自定义镜像。
        /// </summary>
        [JsonProperty("TagSpecification")]
        public TagSpecification[] TagSpecification{ get; set; }

        /// <summary>
        /// 导入镜像后，激活操作系统采用的许可证类型。
        /// 默认值：TencentCloud
        /// 取值范围：
        /// TencentCloud: 腾讯云官方许可
        /// BYOL: 自带许可（Bring Your Own License）
        /// </summary>
        [JsonProperty("LicenseType")]
        public string LicenseType{ get; set; }

        /// <summary>
        /// 启动模式。
        /// 取值范围：`Legacy BIOS`、`UEFI`
        /// 默认值：Legacy BIOS
        /// </summary>
        [JsonProperty("BootMode")]
        public string BootMode{ get; set; }

        /// <summary>
        ///  镜像族
        /// </summary>
        [JsonProperty("ImageFamily")]
        public string ImageFamily{ get; set; }

        /// <summary>
        /// 导入的数据盘列表
        /// </summary>
        [JsonProperty("ImportImageDataDiskList")]
        public ImportImageDataDisk[] ImportImageDataDiskList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Architecture", this.Architecture);
            this.SetParamSimple(map, prefix + "OsType", this.OsType);
            this.SetParamSimple(map, prefix + "OsVersion", this.OsVersion);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "ImageName", this.ImageName);
            this.SetParamSimple(map, prefix + "ImageDescription", this.ImageDescription);
            this.SetParamSimple(map, prefix + "DryRun", this.DryRun);
            this.SetParamSimple(map, prefix + "Force", this.Force);
            this.SetParamArrayObj(map, prefix + "TagSpecification.", this.TagSpecification);
            this.SetParamSimple(map, prefix + "LicenseType", this.LicenseType);
            this.SetParamSimple(map, prefix + "BootMode", this.BootMode);
            this.SetParamSimple(map, prefix + "ImageFamily", this.ImageFamily);
            this.SetParamArrayObj(map, prefix + "ImportImageDataDiskList.", this.ImportImageDataDiskList);
        }
    }
}

