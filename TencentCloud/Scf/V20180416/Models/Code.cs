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

    public class Code : AbstractModel
    {
        
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
        /// 对象存储的地域，地域为北京时需要传入ap-beijing,北京一区时需要传递ap-beijing-1，其他的地域不需要传递。
        /// </summary>
        [JsonProperty("CosBucketRegion")]
        public string CosBucketRegion{ get; set; }

        /// <summary>
        /// 如果是通过Demo创建的话，需要传入DemoId
        /// </summary>
        [JsonProperty("DemoId")]
        public string DemoId{ get; set; }

        /// <summary>
        /// 如果是从TempCos创建的话，需要传入TempCosObjectName
        /// </summary>
        [JsonProperty("TempCosObjectName")]
        public string TempCosObjectName{ get; set; }

        /// <summary>
        /// Git地址
        /// </summary>
        [JsonProperty("GitUrl")]
        public string GitUrl{ get; set; }

        /// <summary>
        /// Git用户名
        /// </summary>
        [JsonProperty("GitUserName")]
        public string GitUserName{ get; set; }

        /// <summary>
        /// Git密码
        /// </summary>
        [JsonProperty("GitPassword")]
        public string GitPassword{ get; set; }

        /// <summary>
        /// 加密后的Git密码，一般无需指定
        /// </summary>
        [JsonProperty("GitPasswordSecret")]
        public string GitPasswordSecret{ get; set; }

        /// <summary>
        /// Git分支
        /// </summary>
        [JsonProperty("GitBranch")]
        public string GitBranch{ get; set; }

        /// <summary>
        /// 代码在Git仓库中的路径
        /// </summary>
        [JsonProperty("GitDirectory")]
        public string GitDirectory{ get; set; }

        /// <summary>
        /// 指定要拉取的版本
        /// </summary>
        [JsonProperty("GitCommitId")]
        public string GitCommitId{ get; set; }

        /// <summary>
        /// 加密后的Git用户名，一般无需指定
        /// </summary>
        [JsonProperty("GitUserNameSecret")]
        public string GitUserNameSecret{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CosBucketName", this.CosBucketName);
            this.SetParamSimple(map, prefix + "CosObjectName", this.CosObjectName);
            this.SetParamSimple(map, prefix + "ZipFile", this.ZipFile);
            this.SetParamSimple(map, prefix + "CosBucketRegion", this.CosBucketRegion);
            this.SetParamSimple(map, prefix + "DemoId", this.DemoId);
            this.SetParamSimple(map, prefix + "TempCosObjectName", this.TempCosObjectName);
            this.SetParamSimple(map, prefix + "GitUrl", this.GitUrl);
            this.SetParamSimple(map, prefix + "GitUserName", this.GitUserName);
            this.SetParamSimple(map, prefix + "GitPassword", this.GitPassword);
            this.SetParamSimple(map, prefix + "GitPasswordSecret", this.GitPasswordSecret);
            this.SetParamSimple(map, prefix + "GitBranch", this.GitBranch);
            this.SetParamSimple(map, prefix + "GitDirectory", this.GitDirectory);
            this.SetParamSimple(map, prefix + "GitCommitId", this.GitCommitId);
            this.SetParamSimple(map, prefix + "GitUserNameSecret", this.GitUserNameSecret);
        }
    }
}

