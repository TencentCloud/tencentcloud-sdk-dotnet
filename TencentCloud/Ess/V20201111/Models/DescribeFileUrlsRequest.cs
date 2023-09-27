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

    public class DescribeFileUrlsRequest : AbstractModel
    {
        
        /// <summary>
        /// 执行本接口操作的员工信息。
        /// 注: `在调用此接口时，请确保指定的员工已获得所需的接口调用权限，并具备接口传入的相应资源的数据权限。`
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 文件对应的业务类型，目前支持：
        /// <ul>
        /// <li>**FLOW ** : 如需下载合同文件请选择此项</li>
        /// <li>**TEMPLATE ** : 如需下载模板文件请选择此项</li>
        /// <li>**DOCUMENT  **: 如需下载文档文件请选择此项</li>
        /// <li>**SEAL  **: 如需下载印章图片请选择此项</li>
        /// </ul>
        /// </summary>
        [JsonProperty("BusinessType")]
        public string BusinessType{ get; set; }

        /// <summary>
        /// 业务编号的数组，取值如下：
        /// <ul>
        /// <li>流程编号</li>
        /// <li>模板编号</li>
        /// <li>文档编号</li>
        /// <li>印章编号</li>
        /// <li>如需下载合同文件请传入FlowId，最大支持20个资源</li>
        /// </ul>
        /// </summary>
        [JsonProperty("BusinessIds")]
        public string[] BusinessIds{ get; set; }

        /// <summary>
        /// 下载后的文件命名，只有FileType为zip的时候生效
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// 要下载的文件类型，取值如下：
        /// <ul>
        /// <li>JPG</li>
        /// <li>PDF</li>
        /// <li>ZIP</li>
        /// </ul>
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }

        /// <summary>
        /// 指定分页返回第几页的数据，如果不传默认返回第一页，页码从 0 开始，即首页为 0，最大 1000。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 指定分页每页返回的数据条数，如果不传默认为 20，单页最大支持 100。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 下载url过期时间，单位秒。0: 按默认值5分钟，允许范围：1s~24x60x60s(1天)
        /// </summary>
        [JsonProperty("UrlTtl")]
        public long? UrlTtl{ get; set; }

        /// <summary>
        /// 暂不开放
        /// </summary>
        [JsonProperty("CcToken")]
        [System.Obsolete]
        public string CcToken{ get; set; }

        /// <summary>
        /// 暂不开放
        /// </summary>
        [JsonProperty("Scene")]
        [System.Obsolete]
        public string Scene{ get; set; }

        /// <summary>
        /// 代理企业和员工的信息。
        /// 在集团企业代理子企业操作的场景中，需设置此参数。在此情境下，ProxyOrganizationId（子企业的组织ID）为必填项。
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamSimple(map, prefix + "BusinessType", this.BusinessType);
            this.SetParamArraySimple(map, prefix + "BusinessIds.", this.BusinessIds);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "UrlTtl", this.UrlTtl);
            this.SetParamSimple(map, prefix + "CcToken", this.CcToken);
            this.SetParamSimple(map, prefix + "Scene", this.Scene);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
        }
    }
}

