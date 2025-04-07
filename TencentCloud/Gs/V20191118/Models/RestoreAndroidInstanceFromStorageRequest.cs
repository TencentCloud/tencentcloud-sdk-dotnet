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

namespace TencentCloud.Gs.V20191118.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RestoreAndroidInstanceFromStorageRequest : AbstractModel
    {
        
        /// <summary>
        /// 安卓实例ID
        /// </summary>
        [JsonProperty("AndroidInstanceId")]
        public string AndroidInstanceId{ get; set; }

        /// <summary>
        /// 自定义备份对象Key
        /// </summary>
        [JsonProperty("ObjectKey")]
        public string ObjectKey{ get; set; }

        /// <summary>
        /// 存储服务器类型，如 COS、S3。注意：使用 COS 和 S3 都将占用外网带宽。
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }

        /// <summary>
        /// COS协议选项
        /// </summary>
        [JsonProperty("COSOptions")]
        public COSOptions COSOptions{ get; set; }

        /// <summary>
        /// S3存储协议选项
        /// </summary>
        [JsonProperty("S3Options")]
        public S3Options S3Options{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AndroidInstanceId", this.AndroidInstanceId);
            this.SetParamSimple(map, prefix + "ObjectKey", this.ObjectKey);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamObj(map, prefix + "COSOptions.", this.COSOptions);
            this.SetParamObj(map, prefix + "S3Options.", this.S3Options);
        }
    }
}

