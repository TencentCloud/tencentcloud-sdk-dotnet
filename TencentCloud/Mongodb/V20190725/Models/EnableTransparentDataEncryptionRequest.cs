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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EnableTransparentDataEncryptionRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例 ID，例如：cmgo-p8vn****。请登录 [MongoDB 控制台](https://console.cloud.tencent.com/mongodb)在实例列表复制实例 ID。目前支持通用版本包含：4.4、5.0，云盘版暂不支持。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        ///  [密钥管理系统（Key Management Service，KMS）](https://cloud.tencent.com/document/product/573/18809)服务所在地域，例如 ap-shanghai。
        /// </summary>
        [JsonProperty("KmsRegion")]
        public string KmsRegion{ get; set; }

        /// <summary>
        /// 密钥 ID。若不设置该参数，不指定具体的密钥 ID，由腾讯云自动生成密钥。
        /// </summary>
        [JsonProperty("KeyId")]
        public string KeyId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "KmsRegion", this.KmsRegion);
            this.SetParamSimple(map, prefix + "KeyId", this.KeyId);
        }
    }
}

