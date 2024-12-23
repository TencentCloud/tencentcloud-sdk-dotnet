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

    public class UploadFilesRequest : AbstractModel
    {
        
        /// <summary>
        /// 文件对应业务类型,可以选择的类型如下
        /// <ul><li> **TEMPLATE** : 此上传的文件用户生成合同模板，文件类型支持.pdf/.doc/.docx/.html格式，如果非pdf文件需要通过<a href="https://qian.tencent.com/developers/companyApis/templatesAndFiles/CreateConvertTaskApi" target="_blank">创建文件转换任务</a>转换后才能使用</li>
        /// <li> **DOCUMENT** : 此文件用来发起合同流程，文件类型支持.pdf/.doc/.docx/.jpg/.png/.xls.xlsx/.html，如果非pdf文件需要通过<a href="https://qian.tencent.com/developers/companyApis/templatesAndFiles/CreateConvertTaskApi" target="_blank">创建文件转换任务</a>转换后才能使用</li>
        /// <li> **SEAL** : 此文件用于印章的生成，文件类型支持.jpg/.jpeg/.png</li></ul>
        /// </summary>
        [JsonProperty("BusinessType")]
        public string BusinessType{ get; set; }

        /// <summary>
        /// 执行本接口操作的员工信息。其中OperatorId为必填字段，即用户的UserId。
        /// 注: `在调用此接口时，请确保指定的员工已获得所需的接口调用权限，并具备接口传入的相应资源的数据权限。`
        /// </summary>
        [JsonProperty("Caller")]
        public Caller Caller{ get; set; }

        /// <summary>
        /// 请上传文件内容数组，最多可上传20个文件。
        /// 
        /// <b>所有文件必须符合<font color="red">FileType</font>指定的文件类型。</b>
        /// </summary>
        [JsonProperty("FileInfos")]
        public UploadFile[] FileInfos{ get; set; }

        /// <summary>
        /// 文件类型， 默认通过文件内容和文件后缀一起解析得到文件类型，调用接口时可以显示的指定上传文件的类型。
        /// 可支持的指定类型如下:
        /// <ul><li>pdf</li>
        /// <li>doc</li>
        /// <li>docx</li>
        /// <li>xls</li>
        /// <li>xlsx</li>
        /// <li>html</li>
        /// <li>jpg</li>
        /// <li>jpeg</li>
        /// <li>png</li></ul>
        /// 如：pdf 表示上传的文件 张三入职合同.pdf的文件类型是 pdf
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }

        /// <summary>
        /// 此参数仅对上传的PDF文件有效。其主要作用是确定是否将PDF中的灰色矩阵置为白色。
        /// <ul><li>**true**：将灰色矩阵置为白色。</li>
        /// <li>**false**：无需处理，不会将灰色矩阵置为白色（默认）。</li></ul>
        /// 
        /// 注: `该参数仅在关键字定位时，需要去除关键字所在的灰框场景下使用。`
        /// </summary>
        [JsonProperty("CoverRect")]
        public bool? CoverRect{ get; set; }

        /// <summary>
        /// 用户自定义ID数组，与上传文件一一对应
        /// 
        /// 注: `历史遗留问题，已经废弃，调用接口时不用赋值`
        /// </summary>
        [JsonProperty("CustomIds")]
        public string[] CustomIds{ get; set; }

        /// <summary>
        /// 不再使用，上传文件链接数组，最多支持20个URL
        /// </summary>
        [JsonProperty("FileUrls")]
        [System.Obsolete]
        public string FileUrls{ get; set; }

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
            this.SetParamSimple(map, prefix + "BusinessType", this.BusinessType);
            this.SetParamObj(map, prefix + "Caller.", this.Caller);
            this.SetParamArrayObj(map, prefix + "FileInfos.", this.FileInfos);
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamSimple(map, prefix + "CoverRect", this.CoverRect);
            this.SetParamArraySimple(map, prefix + "CustomIds.", this.CustomIds);
            this.SetParamSimple(map, prefix + "FileUrls", this.FileUrls);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
        }
    }
}

