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

namespace TencentCloud.Ape.V20200513.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImageInfo : AbstractModel
    {
        
        /// <summary>
        /// 图片Id
        /// </summary>
        [JsonProperty("ImageId")]
        public long? ImageId{ get; set; }

        /// <summary>
        /// 授权场景Id
        /// </summary>
        [JsonProperty("LicenseScopeId")]
        public long? LicenseScopeId{ get; set; }

        /// <summary>
        /// 尺寸名称Id
        /// </summary>
        [JsonProperty("DimensionsNameId")]
        public long? DimensionsNameId{ get; set; }

        /// <summary>
        /// 平台用户标识
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 平台用户下载图片购买的价格(单位:分)
        /// </summary>
        [JsonProperty("DownloadPrice")]
        public ulong? DownloadPrice{ get; set; }

        /// <summary>
        /// 下载类型。匹配集合中的任意元素：
        /// <li>Single: 单张购买下载</li>
        /// <li>BasicEnterpriseMember: 企业基础会员下载</li>
        /// <li>AdvancedEnterpriseMember: 企业高级会员下载</li>
        /// <li>DistinguishedEnterpriseMember: 企业尊享会员下载</li>
        /// </summary>
        [JsonProperty("DownloadType")]
        public string DownloadType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "LicenseScopeId", this.LicenseScopeId);
            this.SetParamSimple(map, prefix + "DimensionsNameId", this.DimensionsNameId);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "DownloadPrice", this.DownloadPrice);
            this.SetParamSimple(map, prefix + "DownloadType", this.DownloadType);
        }
    }
}

