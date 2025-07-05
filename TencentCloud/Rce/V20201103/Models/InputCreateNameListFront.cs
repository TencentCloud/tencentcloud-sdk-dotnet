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

namespace TencentCloud.Rce.V20201103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InputCreateNameListFront : AbstractModel
    {
        
        /// <summary>
        /// 名单名称
        /// </summary>
        [JsonProperty("ListName")]
        public string ListName{ get; set; }

        /// <summary>
        /// 名单类型 [1 黑名单 2白名单]
        /// </summary>
        [JsonProperty("ListType")]
        public long? ListType{ get; set; }

        /// <summary>
        /// 数据类型[1 手机号 2 qqOpenId 3 2echatOpenId 4 ip 6 idfa 7 imei]
        /// </summary>
        [JsonProperty("DataType")]
        public long? DataType{ get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 加密类型[0 无需加密 1 MD5加密 2 SHA256加密]
        /// </summary>
        [JsonProperty("EncryptionType")]
        public long? EncryptionType{ get; set; }

        /// <summary>
        /// 场景Code，all_scene代表全部场景
        /// </summary>
        [JsonProperty("SceneCode")]
        public string SceneCode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ListName", this.ListName);
            this.SetParamSimple(map, prefix + "ListType", this.ListType);
            this.SetParamSimple(map, prefix + "DataType", this.DataType);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "EncryptionType", this.EncryptionType);
            this.SetParamSimple(map, prefix + "SceneCode", this.SceneCode);
        }
    }
}

