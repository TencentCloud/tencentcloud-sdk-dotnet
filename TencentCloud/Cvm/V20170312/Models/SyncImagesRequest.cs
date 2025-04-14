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

    public class SyncImagesRequest : AbstractModel
    {
        
        /// <summary>
        /// 镜像ID列表 ，镜像ID可以通过如下方式获取：<br><li>通过[DescribeImages](https://cloud.tencent.com/document/api/213/15715)接口返回的`ImageId`获取，镜像ID对应的镜像状态必须为`NORMAL`。</li><li>通过[镜像控制台](https://console.cloud.tencent.com/cvm/image)获取。</li>
        /// </summary>
        [JsonProperty("ImageIds")]
        public string[] ImageIds{ get; set; }

        /// <summary>
        /// 目的同步地域列表，必须满足如下限制：<br><li>必须是一个合法的Region。</li><li>如果是自定义镜像，则目标同步地域不能为源地域。</li><li>如果是共享镜像，则目的同步地域仅支持源地域，表示将共享镜像复制为源地域的自定义镜像。</li><li>如果是自定义镜像复制为加密自定义镜像，则目的同步地域仅支持源地域，表示将自定义镜像复制为源地域的加密自定义镜像。</li><li>暂不支持部分地域同步，请参考[复制镜像](https://cloud.tencent.com/document/product/213/4943#.E5.A4.8D.E5.88.B6.E8.AF.B4.E6.98.8E)。</li>具体地域参数请参考[Region](https://cloud.tencent.com/document/product/213/6091)。
        /// </summary>
        [JsonProperty("DestinationRegions")]
        public string[] DestinationRegions{ get; set; }

        /// <summary>
        /// 检测是否支持发起同步镜像。
        /// 默认值: false
        /// </summary>
        [JsonProperty("DryRun")]
        public bool? DryRun{ get; set; }

        /// <summary>
        /// 目标镜像名称。默认使用源镜像名称。
        /// 最多支持 60 个字符。
        /// </summary>
        [JsonProperty("ImageName")]
        public string ImageName{ get; set; }

        /// <summary>
        /// 是否需要返回目的地域的镜像ID。
        /// 默认值: false
        /// </summary>
        [JsonProperty("ImageSetRequired")]
        public bool? ImageSetRequired{ get; set; }

        /// <summary>
        /// 是否复制为加密自定义镜像。
        /// 默认值为 false。
        /// 复制加密自定义镜像仅支持同地域， 即 DestinationRegions 仅支持填写指定镜像所在地域。
        /// </summary>
        [JsonProperty("Encrypt")]
        public bool? Encrypt{ get; set; }

        /// <summary>
        /// 加密自定义镜像使用的 KMS 密钥 ID。
        /// 仅当复制加密镜像时，即 Encrypt 为 true 时，此参数有效；
        /// 不指定 KmsKeyId，默认使用 CBS 云产品 KMS 密钥。
        /// KMS 密钥 ID 通过[KMS 控制台](https://console.cloud.tencent.com/kms2)获取。
        /// </summary>
        [JsonProperty("KmsKeyId")]
        public string KmsKeyId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ImageIds.", this.ImageIds);
            this.SetParamArraySimple(map, prefix + "DestinationRegions.", this.DestinationRegions);
            this.SetParamSimple(map, prefix + "DryRun", this.DryRun);
            this.SetParamSimple(map, prefix + "ImageName", this.ImageName);
            this.SetParamSimple(map, prefix + "ImageSetRequired", this.ImageSetRequired);
            this.SetParamSimple(map, prefix + "Encrypt", this.Encrypt);
            this.SetParamSimple(map, prefix + "KmsKeyId", this.KmsKeyId);
        }
    }
}

