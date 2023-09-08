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

    public class CreateConvertTaskApiRequest : AbstractModel
    {
        
        /// <summary>
        /// 需要进行转换的资源文件类型
        /// 支持的文件类型如下：
        /// <ul><li>doc</li>
        /// <li>docx</li>
        /// <li>xls</li>
        /// <li>xlsx</li>
        /// <li>jpg</li>
        /// <li>jpeg</li>
        /// <li>png</li>
        /// <li>bmp</li>
        /// <li>txt</li></ul>
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// 需要进行转换操作的文件资源名称，带资源后缀名。
        /// 
        /// 注:  `资源名称长度限制为256个字符`
        /// </summary>
        [JsonProperty("ResourceName")]
        public string ResourceName{ get; set; }

        /// <summary>
        /// 需要进行转换操作的文件资源Id，通过<a href="https://qian.tencent.com/developers/companyApis/templatesAndFiles/UploadFiles" target="_blank">UploadFiles</a>接口获取文件资源Id。
        /// 
        /// 注:  `目前，此接口仅支持单个文件进行转换。`
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 执行本接口操作的员工信息。
        /// 注: `在调用此接口时，请确保指定的员工已获得所需的接口调用权限，并具备接口传入的相应资源的数据权限。
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 代理企业和员工的信息。
        /// 在集团企业代理子企业操作的场景中，需设置此参数。在此情境下，ProxyOrganizationId（子企业的组织ID）为必填项。
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 暂未开放
        /// </summary>
        [JsonProperty("Organization")]
        [System.Obsolete]
        public OrganizationInfo Organization{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "ResourceName", this.ResourceName);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamObj(map, prefix + "Organization.", this.Organization);
        }
    }
}

