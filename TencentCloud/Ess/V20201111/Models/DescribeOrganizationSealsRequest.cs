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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeOrganizationSealsRequest : AbstractModel
    {
        
        /// <summary>
        /// 调用方用户信息，userId 必填
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 返回最大数量，最大为100
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 偏移量，默认为0，最大为20000
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 查询信息类型，为0时不返回授权用户，为1时返回
        /// </summary>
        [JsonProperty("InfoType")]
        public long? InfoType{ get; set; }

        /// <summary>
        /// 印章id（没有输入返回所有）
        /// </summary>
        [JsonProperty("SealId")]
        public string SealId{ get; set; }

        /// <summary>
        /// 印章类型列表（都是组织机构印章）。
        /// 为空时查询所有类型的印章。
        /// 目前支持以下类型：
        /// OFFICIAL：企业公章；
        /// CONTRACT：合同专用章；
        /// ORGANIZATION_SEAL：企业印章(图片上传创建)；
        /// LEGAL_PERSON_SEAL：法定代表人章
        /// </summary>
        [JsonProperty("SealTypes")]
        public string[] SealTypes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "InfoType", this.InfoType);
            this.SetParamSimple(map, prefix + "SealId", this.SealId);
            this.SetParamArraySimple(map, prefix + "SealTypes.", this.SealTypes);
        }
    }
}

