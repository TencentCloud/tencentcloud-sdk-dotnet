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

namespace TencentCloud.Scf.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateFunctionCodeRequest : AbstractModel
    {
        
        /// <summary>
        /// 函数处理方法名称。名称格式支持“文件名称.函数名称”形式，文件名称和函数名称之间以"."隔开，文件名称和函数名称要求以字母开始和结尾，中间允许插入字母、数字、下划线和连接符，文件名称和函数名字的长度要求 2-60 个字符
        /// </summary>
        [JsonProperty("Handler")]
        public string Handler{ get; set; }

        /// <summary>
        /// 要修改的函数名称
        /// </summary>
        [JsonProperty("FunctionName")]
        public string FunctionName{ get; set; }

        /// <summary>
        /// 对象存储桶名称
        /// </summary>
        [JsonProperty("CosBucketName")]
        public string CosBucketName{ get; set; }

        /// <summary>
        /// 对象存储对象路径
        /// </summary>
        [JsonProperty("CosObjectName")]
        public string CosObjectName{ get; set; }

        /// <summary>
        /// 包含函数代码文件及其依赖项的 zip 格式文件，使用该接口时要求将 zip 文件的内容转成 base64 编码，最大支持20M
        /// </summary>
        [JsonProperty("ZipFile")]
        public string ZipFile{ get; set; }

        /// <summary>
        /// 函数所属命名空间
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// 对象存储的地域，注：北京分为ap-beijing和ap-beijing-1
        /// </summary>
        [JsonProperty("CosBucketRegion")]
        public string CosBucketRegion{ get; set; }

        /// <summary>
        /// 函数所属环境
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// 在更新时是否同步发布新版本，默认为：FALSE，不发布
        /// </summary>
        [JsonProperty("Publish")]
        public string Publish{ get; set; }

        /// <summary>
        /// 函数代码
        /// </summary>
        [JsonProperty("Code")]
        public Code Code{ get; set; }

        /// <summary>
        /// 代码来源方式，支持以下'ZipFile', 'Cos', 'Inline', 'TempCos', 'Git' 之一，使用Git来源必须指定此字段
        /// </summary>
        [JsonProperty("CodeSource")]
        public string CodeSource{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Handler", this.Handler);
            this.SetParamSimple(map, prefix + "FunctionName", this.FunctionName);
            this.SetParamSimple(map, prefix + "CosBucketName", this.CosBucketName);
            this.SetParamSimple(map, prefix + "CosObjectName", this.CosObjectName);
            this.SetParamSimple(map, prefix + "ZipFile", this.ZipFile);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "CosBucketRegion", this.CosBucketRegion);
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamSimple(map, prefix + "Publish", this.Publish);
            this.SetParamObj(map, prefix + "Code.", this.Code);
            this.SetParamSimple(map, prefix + "CodeSource", this.CodeSource);
        }
    }
}

