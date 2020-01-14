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

namespace TencentCloud.Iai.V20180301
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Iai.V20180301.Models;

   public class IaiClient : AbstractClient{

       private const string endpoint = "iai.tencentcloudapi.com";
       private const string version = "2018-03-01";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public IaiClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public IaiClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 对请求图片进行五官定位（也称人脸关键点定位），计算构成人脸轮廓的 90 个点，包括眉毛（左右各 8 点）、眼睛（左右各 8 点）、鼻子（13 点）、嘴巴（22 点）、脸型轮廓（21 点）、眼珠[或瞳孔]（2点）。
        /// 
        /// >     
        /// - 公共参数中的签名方式请使用V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// </summary>
        /// <param name="req"><see cref="AnalyzeFaceRequest"/></param>
        /// <returns><see cref="AnalyzeFaceResponse"/></returns>
        public async Task<AnalyzeFaceResponse> AnalyzeFace(AnalyzeFaceRequest req)
        {
             JsonResponseModel<AnalyzeFaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AnalyzeFace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AnalyzeFaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// AnalyzeFace接口的同步版本，对请求图片进行五官定位（也称人脸关键点定位），计算构成人脸轮廓的 90 个点，包括眉毛（左右各 8 点）、眼睛（左右各 8 点）、鼻子（13 点）、嘴巴（22 点）、脸型轮廓（21 点）、眼珠[或瞳孔]（2点）。
        /// 
        /// >     
        /// - 公共参数中的签名方式请使用V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// </summary>
        /// <param name="req">参考<see cref="AnalyzeFaceRequest"/></param>
        /// <returns>参考<see cref="AnalyzeFaceResponse"/>实例</returns>
        public AnalyzeFaceResponse AnalyzeFaceSync(AnalyzeFaceRequest req)
        {
             JsonResponseModel<AnalyzeFaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AnalyzeFace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AnalyzeFaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对指定的人员库进行查重，给出疑似相同人的信息。
        /// 
        /// 不支持跨算法模型版本查重，且目前仅支持算法模型为3.0的人员库使用查重功能。
        /// 
        /// >     
        /// - 若对完全相同的指定人员库进行查重操作，需等待上次操作完成才可。即，若两次请求输入的 GroupIds 相同，第一次请求若未完成，第二次请求将返回失败。<br>
        /// 查重的人员库状态为腾讯云开始进行查重任务的那一刻，即您可以理解为当您发起查重请求后，若您的查重任务需要排队，在排队期间您对人员库的增删操作均会会影响查重的结果。腾讯云将以开始进行查重任务的那一刻人员库的状态进行查重。查重任务开始后，您对人员库的任何操作均不影响查重任务的进行。但建议查重任务开始后，请不要对人员库中人员和人脸进行增删操作。
        /// </summary>
        /// <param name="req"><see cref="CheckSimilarPersonRequest"/></param>
        /// <returns><see cref="CheckSimilarPersonResponse"/></returns>
        public async Task<CheckSimilarPersonResponse> CheckSimilarPerson(CheckSimilarPersonRequest req)
        {
             JsonResponseModel<CheckSimilarPersonResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckSimilarPerson");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckSimilarPersonResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CheckSimilarPerson接口的同步版本，对指定的人员库进行查重，给出疑似相同人的信息。
        /// 
        /// 不支持跨算法模型版本查重，且目前仅支持算法模型为3.0的人员库使用查重功能。
        /// 
        /// >     
        /// - 若对完全相同的指定人员库进行查重操作，需等待上次操作完成才可。即，若两次请求输入的 GroupIds 相同，第一次请求若未完成，第二次请求将返回失败。<br>
        /// 查重的人员库状态为腾讯云开始进行查重任务的那一刻，即您可以理解为当您发起查重请求后，若您的查重任务需要排队，在排队期间您对人员库的增删操作均会会影响查重的结果。腾讯云将以开始进行查重任务的那一刻人员库的状态进行查重。查重任务开始后，您对人员库的任何操作均不影响查重任务的进行。但建议查重任务开始后，请不要对人员库中人员和人脸进行增删操作。
        /// </summary>
        /// <param name="req">参考<see cref="CheckSimilarPersonRequest"/></param>
        /// <returns>参考<see cref="CheckSimilarPersonResponse"/>实例</returns>
        public CheckSimilarPersonResponse CheckSimilarPersonSync(CheckSimilarPersonRequest req)
        {
             JsonResponseModel<CheckSimilarPersonResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckSimilarPerson");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckSimilarPersonResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对两张图片中的人脸进行相似度比对，返回人脸相似度分数。
        /// 
        /// 若您需要判断 “此人是否是某人”，即验证某张图片中的人是否是已知身份的某人，如常见的人脸登录场景，建议使用[人脸验证](https://cloud.tencent.com/document/product/867/32806)接口。
        /// 
        /// >     
        /// - 公共参数中的签名方式请使用V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// </summary>
        /// <param name="req"><see cref="CompareFaceRequest"/></param>
        /// <returns><see cref="CompareFaceResponse"/></returns>
        public async Task<CompareFaceResponse> CompareFace(CompareFaceRequest req)
        {
             JsonResponseModel<CompareFaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CompareFace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CompareFaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CompareFace接口的同步版本，对两张图片中的人脸进行相似度比对，返回人脸相似度分数。
        /// 
        /// 若您需要判断 “此人是否是某人”，即验证某张图片中的人是否是已知身份的某人，如常见的人脸登录场景，建议使用[人脸验证](https://cloud.tencent.com/document/product/867/32806)接口。
        /// 
        /// >     
        /// - 公共参数中的签名方式请使用V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// </summary>
        /// <param name="req">参考<see cref="CompareFaceRequest"/></param>
        /// <returns>参考<see cref="CompareFaceResponse"/>实例</returns>
        public CompareFaceResponse CompareFaceSync(CompareFaceRequest req)
        {
             JsonResponseModel<CompareFaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CompareFace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CompareFaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 将已存在于某人员库的人员复制到其他人员库，该人员的描述信息不会被复制。单个人员最多只能同时存在100个人员库中。
        /// >     
        /// - 注：若该人员创建时算法模型版本为2.0，复制到非2.0算法模型版本的Group中时，复制操作将会失败。
        /// </summary>
        /// <param name="req"><see cref="CopyPersonRequest"/></param>
        /// <returns><see cref="CopyPersonResponse"/></returns>
        public async Task<CopyPersonResponse> CopyPerson(CopyPersonRequest req)
        {
             JsonResponseModel<CopyPersonResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CopyPerson");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CopyPersonResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CopyPerson接口的同步版本，将已存在于某人员库的人员复制到其他人员库，该人员的描述信息不会被复制。单个人员最多只能同时存在100个人员库中。
        /// >     
        /// - 注：若该人员创建时算法模型版本为2.0，复制到非2.0算法模型版本的Group中时，复制操作将会失败。
        /// </summary>
        /// <param name="req">参考<see cref="CopyPersonRequest"/></param>
        /// <returns>参考<see cref="CopyPersonResponse"/>实例</returns>
        public CopyPersonResponse CopyPersonSync(CopyPersonRequest req)
        {
             JsonResponseModel<CopyPersonResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CopyPerson");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CopyPersonResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 将一组人脸图片添加到一个人员中。一个人员最多允许包含 5 张图片。若该人员存在多个人员库中，所有人员库中该人员图片均会增加。
        /// 
        /// >     
        /// - 公共参数中的签名方式请使用V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// </summary>
        /// <param name="req"><see cref="CreateFaceRequest"/></param>
        /// <returns><see cref="CreateFaceResponse"/></returns>
        public async Task<CreateFaceResponse> CreateFace(CreateFaceRequest req)
        {
             JsonResponseModel<CreateFaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateFace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateFace接口的同步版本，将一组人脸图片添加到一个人员中。一个人员最多允许包含 5 张图片。若该人员存在多个人员库中，所有人员库中该人员图片均会增加。
        /// 
        /// >     
        /// - 公共参数中的签名方式请使用V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// </summary>
        /// <param name="req">参考<see cref="CreateFaceRequest"/></param>
        /// <returns>参考<see cref="CreateFaceResponse"/>实例</returns>
        public CreateFaceResponse CreateFaceSync(CreateFaceRequest req)
        {
             JsonResponseModel<CreateFaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateFace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于创建一个空的人员库，如果人员库已存在返回错误。可根据需要创建自定义描述字段，用于辅助描述该人员库下的人员信息。1个APPID下最多创建2万个人员库（Group）、最多包含1000万张人脸（Face），单个人员库（Group）最多包含100万张人脸（Face）。
        /// </summary>
        /// <param name="req"><see cref="CreateGroupRequest"/></param>
        /// <returns><see cref="CreateGroupResponse"/></returns>
        public async Task<CreateGroupResponse> CreateGroup(CreateGroupRequest req)
        {
             JsonResponseModel<CreateGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateGroup接口的同步版本，用于创建一个空的人员库，如果人员库已存在返回错误。可根据需要创建自定义描述字段，用于辅助描述该人员库下的人员信息。1个APPID下最多创建2万个人员库（Group）、最多包含1000万张人脸（Face），单个人员库（Group）最多包含100万张人脸（Face）。
        /// </summary>
        /// <param name="req">参考<see cref="CreateGroupRequest"/></param>
        /// <returns>参考<see cref="CreateGroupResponse"/>实例</returns>
        public CreateGroupResponse CreateGroupSync(CreateGroupRequest req)
        {
             JsonResponseModel<CreateGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建人员，添加人脸、姓名、性别及其他相关信息。
        /// 
        /// >     
        /// - 公共参数中的签名方式请使用V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// </summary>
        /// <param name="req"><see cref="CreatePersonRequest"/></param>
        /// <returns><see cref="CreatePersonResponse"/></returns>
        public async Task<CreatePersonResponse> CreatePerson(CreatePersonRequest req)
        {
             JsonResponseModel<CreatePersonResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePerson");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePersonResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreatePerson接口的同步版本，创建人员，添加人脸、姓名、性别及其他相关信息。
        /// 
        /// >     
        /// - 公共参数中的签名方式请使用V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// </summary>
        /// <param name="req">参考<see cref="CreatePersonRequest"/></param>
        /// <returns>参考<see cref="CreatePersonResponse"/>实例</returns>
        public CreatePersonResponse CreatePersonSync(CreatePersonRequest req)
        {
             JsonResponseModel<CreatePersonResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePerson");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePersonResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除一个人员下的人脸图片。如果该人员只有一张人脸图片，则返回错误。
        /// </summary>
        /// <param name="req"><see cref="DeleteFaceRequest"/></param>
        /// <returns><see cref="DeleteFaceResponse"/></returns>
        public async Task<DeleteFaceResponse> DeleteFace(DeleteFaceRequest req)
        {
             JsonResponseModel<DeleteFaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteFace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteFaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteFace接口的同步版本，删除一个人员下的人脸图片。如果该人员只有一张人脸图片，则返回错误。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteFaceRequest"/></param>
        /// <returns>参考<see cref="DeleteFaceResponse"/>实例</returns>
        public DeleteFaceResponse DeleteFaceSync(DeleteFaceRequest req)
        {
             JsonResponseModel<DeleteFaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteFace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteFaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除该人员库及包含的所有的人员。同时，人员对应的所有人脸信息将被删除。若某人员同时存在多个人员库中，该人员不会被删除，但属于该人员库中的自定义描述字段信息会被删除，属于其他人员库的自定义描述字段信息不受影响。
        /// 
        /// >     
        /// - 删除人员库的操作为异步执行，删除单张人脸时间约为10ms，即一小时内可以删除36万张。删除期间，无法向该人员库添加人员。
        /// </summary>
        /// <param name="req"><see cref="DeleteGroupRequest"/></param>
        /// <returns><see cref="DeleteGroupResponse"/></returns>
        public async Task<DeleteGroupResponse> DeleteGroup(DeleteGroupRequest req)
        {
             JsonResponseModel<DeleteGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteGroup接口的同步版本，删除该人员库及包含的所有的人员。同时，人员对应的所有人脸信息将被删除。若某人员同时存在多个人员库中，该人员不会被删除，但属于该人员库中的自定义描述字段信息会被删除，属于其他人员库的自定义描述字段信息不受影响。
        /// 
        /// >     
        /// - 删除人员库的操作为异步执行，删除单张人脸时间约为10ms，即一小时内可以删除36万张。删除期间，无法向该人员库添加人员。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteGroupRequest"/></param>
        /// <returns>参考<see cref="DeleteGroupResponse"/>实例</returns>
        public DeleteGroupResponse DeleteGroupSync(DeleteGroupRequest req)
        {
             JsonResponseModel<DeleteGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除该人员信息，此操作会导致所有人员库均删除此人员。同时，该人员的所有人脸信息将被删除。
        /// </summary>
        /// <param name="req"><see cref="DeletePersonRequest"/></param>
        /// <returns><see cref="DeletePersonResponse"/></returns>
        public async Task<DeletePersonResponse> DeletePerson(DeletePersonRequest req)
        {
             JsonResponseModel<DeletePersonResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePerson");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePersonResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeletePerson接口的同步版本，删除该人员信息，此操作会导致所有人员库均删除此人员。同时，该人员的所有人脸信息将被删除。
        /// </summary>
        /// <param name="req">参考<see cref="DeletePersonRequest"/></param>
        /// <returns>参考<see cref="DeletePersonResponse"/>实例</returns>
        public DeletePersonResponse DeletePersonSync(DeletePersonRequest req)
        {
             JsonResponseModel<DeletePersonResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeletePerson");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePersonResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 从某人员库中删除人员，此操作仅影响该人员库。若该人员仅存在于指定的人员库中，该人员将被删除，其所有的人脸信息也将被删除。
        /// </summary>
        /// <param name="req"><see cref="DeletePersonFromGroupRequest"/></param>
        /// <returns><see cref="DeletePersonFromGroupResponse"/></returns>
        public async Task<DeletePersonFromGroupResponse> DeletePersonFromGroup(DeletePersonFromGroupRequest req)
        {
             JsonResponseModel<DeletePersonFromGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePersonFromGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePersonFromGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeletePersonFromGroup接口的同步版本，从某人员库中删除人员，此操作仅影响该人员库。若该人员仅存在于指定的人员库中，该人员将被删除，其所有的人脸信息也将被删除。
        /// </summary>
        /// <param name="req">参考<see cref="DeletePersonFromGroupRequest"/></param>
        /// <returns>参考<see cref="DeletePersonFromGroupResponse"/>实例</returns>
        public DeletePersonFromGroupResponse DeletePersonFromGroupSync(DeletePersonFromGroupRequest req)
        {
             JsonResponseModel<DeletePersonFromGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeletePersonFromGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePersonFromGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 检测给定图片中的人脸（Face）的位置、相应的面部属性和人脸质量信息，位置包括 (x，y，w，h)，面部属性包括性别（gender）、年龄（age）、表情（expression）、魅力（beauty）、眼镜（glass）、发型（hair）、口罩（mask）和姿态 (pitch，roll，yaw)，人脸质量信息包括整体质量分（score）、模糊分（sharpness）、光照分（brightness）和五官遮挡分（completeness）。
        /// 
        ///  
        /// 其中，人脸质量信息主要用于评价输入的人脸图片的质量。在使用人脸识别服务时，建议您对输入的人脸图片进行质量检测，提升后续业务处理的效果。该功能的应用场景包括：
        /// 
        /// 1） 人员库[创建人员](https://cloud.tencent.com/document/product/867/32793)/[增加人脸](https://cloud.tencent.com/document/product/867/32795)：保证人员人脸信息的质量，便于后续的业务处理。
        /// 
        /// 2） [人脸搜索](https://cloud.tencent.com/document/product/867/32798)：保证输入的图片质量，快速准确匹配到对应的人员。
        /// 
        /// 3） [人脸验证](https://cloud.tencent.com/document/product/867/32806)：保证人脸信息的质量，避免明明是本人却认证不通过的情况。
        /// 
        /// 4） [人脸融合](https://cloud.tencent.com/product/facefusion)：保证上传的人脸质量，人脸融合的效果更好。
        /// 
        /// >     
        /// - 公共参数中的签名方式请使用V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// 
        /// </summary>
        /// <param name="req"><see cref="DetectFaceRequest"/></param>
        /// <returns><see cref="DetectFaceResponse"/></returns>
        public async Task<DetectFaceResponse> DetectFace(DetectFaceRequest req)
        {
             JsonResponseModel<DetectFaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DetectFace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetectFaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DetectFace接口的同步版本，检测给定图片中的人脸（Face）的位置、相应的面部属性和人脸质量信息，位置包括 (x，y，w，h)，面部属性包括性别（gender）、年龄（age）、表情（expression）、魅力（beauty）、眼镜（glass）、发型（hair）、口罩（mask）和姿态 (pitch，roll，yaw)，人脸质量信息包括整体质量分（score）、模糊分（sharpness）、光照分（brightness）和五官遮挡分（completeness）。
        /// 
        ///  
        /// 其中，人脸质量信息主要用于评价输入的人脸图片的质量。在使用人脸识别服务时，建议您对输入的人脸图片进行质量检测，提升后续业务处理的效果。该功能的应用场景包括：
        /// 
        /// 1） 人员库[创建人员](https://cloud.tencent.com/document/product/867/32793)/[增加人脸](https://cloud.tencent.com/document/product/867/32795)：保证人员人脸信息的质量，便于后续的业务处理。
        /// 
        /// 2） [人脸搜索](https://cloud.tencent.com/document/product/867/32798)：保证输入的图片质量，快速准确匹配到对应的人员。
        /// 
        /// 3） [人脸验证](https://cloud.tencent.com/document/product/867/32806)：保证人脸信息的质量，避免明明是本人却认证不通过的情况。
        /// 
        /// 4） [人脸融合](https://cloud.tencent.com/product/facefusion)：保证上传的人脸质量，人脸融合的效果更好。
        /// 
        /// >     
        /// - 公共参数中的签名方式请使用V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// 
        /// </summary>
        /// <param name="req">参考<see cref="DetectFaceRequest"/></param>
        /// <returns>参考<see cref="DetectFaceResponse"/>实例</returns>
        public DetectFaceResponse DetectFaceSync(DetectFaceRequest req)
        {
             JsonResponseModel<DetectFaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DetectFace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetectFaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于对用户上传的静态图片进行人脸活体检测。与动态活体检测的区别是：静态活体检测中，用户不需要通过唇语或摇头眨眼等动作来识别。
        /// 
        /// 静态活体检测适用于手机自拍的场景，或对防攻击要求不高的场景。如果对活体检测有更高安全性要求，请使用[人脸核身·云智慧眼](https://cloud.tencent.com/product/faceid)产品。
        /// 
        /// >     
        /// - 图片的宽高比请接近3：4，不符合宽高比的图片返回的分值不具备参考意义。本接口适用于类手机自拍场景，非类手机自拍照返回的分值不具备参考意义。
        /// 
        /// >     
        /// - 公共参数中的签名方式请使用V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// </summary>
        /// <param name="req"><see cref="DetectLiveFaceRequest"/></param>
        /// <returns><see cref="DetectLiveFaceResponse"/></returns>
        public async Task<DetectLiveFaceResponse> DetectLiveFace(DetectLiveFaceRequest req)
        {
             JsonResponseModel<DetectLiveFaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DetectLiveFace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetectLiveFaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DetectLiveFace接口的同步版本，用于对用户上传的静态图片进行人脸活体检测。与动态活体检测的区别是：静态活体检测中，用户不需要通过唇语或摇头眨眼等动作来识别。
        /// 
        /// 静态活体检测适用于手机自拍的场景，或对防攻击要求不高的场景。如果对活体检测有更高安全性要求，请使用[人脸核身·云智慧眼](https://cloud.tencent.com/product/faceid)产品。
        /// 
        /// >     
        /// - 图片的宽高比请接近3：4，不符合宽高比的图片返回的分值不具备参考意义。本接口适用于类手机自拍场景，非类手机自拍照返回的分值不具备参考意义。
        /// 
        /// >     
        /// - 公共参数中的签名方式请使用V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// </summary>
        /// <param name="req">参考<see cref="DetectLiveFaceRequest"/></param>
        /// <returns>参考<see cref="DetectLiveFaceResponse"/>实例</returns>
        public DetectLiveFaceResponse DetectLiveFaceSync(DetectLiveFaceRequest req)
        {
             JsonResponseModel<DetectLiveFaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DetectLiveFace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetectLiveFaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取若要开始一个人员查重任务，这个任务结束的预估时间。
        /// 
        /// 若EndTimestamp符合您预期，请您尽快发起人员查重请求，否则导致可能需要更多处理时间。
        /// 
        /// 若预估时间超过5小时，则无法使用人员查重功能。
        /// </summary>
        /// <param name="req"><see cref="EstimateCheckSimilarPersonCostTimeRequest"/></param>
        /// <returns><see cref="EstimateCheckSimilarPersonCostTimeResponse"/></returns>
        public async Task<EstimateCheckSimilarPersonCostTimeResponse> EstimateCheckSimilarPersonCostTime(EstimateCheckSimilarPersonCostTimeRequest req)
        {
             JsonResponseModel<EstimateCheckSimilarPersonCostTimeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EstimateCheckSimilarPersonCostTime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EstimateCheckSimilarPersonCostTimeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// EstimateCheckSimilarPersonCostTime接口的同步版本，获取若要开始一个人员查重任务，这个任务结束的预估时间。
        /// 
        /// 若EndTimestamp符合您预期，请您尽快发起人员查重请求，否则导致可能需要更多处理时间。
        /// 
        /// 若预估时间超过5小时，则无法使用人员查重功能。
        /// </summary>
        /// <param name="req">参考<see cref="EstimateCheckSimilarPersonCostTimeRequest"/></param>
        /// <returns>参考<see cref="EstimateCheckSimilarPersonCostTimeResponse"/>实例</returns>
        public EstimateCheckSimilarPersonCostTimeResponse EstimateCheckSimilarPersonCostTimeSync(EstimateCheckSimilarPersonCostTimeRequest req)
        {
             JsonResponseModel<EstimateCheckSimilarPersonCostTimeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EstimateCheckSimilarPersonCostTime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EstimateCheckSimilarPersonCostTimeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取人员库列表。
        /// </summary>
        /// <param name="req"><see cref="GetGroupListRequest"/></param>
        /// <returns><see cref="GetGroupListResponse"/></returns>
        public async Task<GetGroupListResponse> GetGroupList(GetGroupListRequest req)
        {
             JsonResponseModel<GetGroupListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetGroupList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetGroupListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// GetGroupList接口的同步版本，获取人员库列表。
        /// </summary>
        /// <param name="req">参考<see cref="GetGroupListRequest"/></param>
        /// <returns>参考<see cref="GetGroupListResponse"/>实例</returns>
        public GetGroupListResponse GetGroupListSync(GetGroupListRequest req)
        {
             JsonResponseModel<GetGroupListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetGroupList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetGroupListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指定人员的信息，包括姓名、性别、人脸等。
        /// </summary>
        /// <param name="req"><see cref="GetPersonBaseInfoRequest"/></param>
        /// <returns><see cref="GetPersonBaseInfoResponse"/></returns>
        public async Task<GetPersonBaseInfoResponse> GetPersonBaseInfo(GetPersonBaseInfoRequest req)
        {
             JsonResponseModel<GetPersonBaseInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetPersonBaseInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPersonBaseInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// GetPersonBaseInfo接口的同步版本，获取指定人员的信息，包括姓名、性别、人脸等。
        /// </summary>
        /// <param name="req">参考<see cref="GetPersonBaseInfoRequest"/></param>
        /// <returns>参考<see cref="GetPersonBaseInfoResponse"/>实例</returns>
        public GetPersonBaseInfoResponse GetPersonBaseInfoSync(GetPersonBaseInfoRequest req)
        {
             JsonResponseModel<GetPersonBaseInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetPersonBaseInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPersonBaseInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指定人员的信息，包括加入的人员库、描述内容等。
        /// </summary>
        /// <param name="req"><see cref="GetPersonGroupInfoRequest"/></param>
        /// <returns><see cref="GetPersonGroupInfoResponse"/></returns>
        public async Task<GetPersonGroupInfoResponse> GetPersonGroupInfo(GetPersonGroupInfoRequest req)
        {
             JsonResponseModel<GetPersonGroupInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetPersonGroupInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPersonGroupInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// GetPersonGroupInfo接口的同步版本，获取指定人员的信息，包括加入的人员库、描述内容等。
        /// </summary>
        /// <param name="req">参考<see cref="GetPersonGroupInfoRequest"/></param>
        /// <returns>参考<see cref="GetPersonGroupInfoResponse"/>实例</returns>
        public GetPersonGroupInfoResponse GetPersonGroupInfoSync(GetPersonGroupInfoRequest req)
        {
             JsonResponseModel<GetPersonGroupInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetPersonGroupInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPersonGroupInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指定人员库中的人员列表。
        /// </summary>
        /// <param name="req"><see cref="GetPersonListRequest"/></param>
        /// <returns><see cref="GetPersonListResponse"/></returns>
        public async Task<GetPersonListResponse> GetPersonList(GetPersonListRequest req)
        {
             JsonResponseModel<GetPersonListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetPersonList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPersonListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// GetPersonList接口的同步版本，获取指定人员库中的人员列表。
        /// </summary>
        /// <param name="req">参考<see cref="GetPersonListRequest"/></param>
        /// <returns>参考<see cref="GetPersonListResponse"/>实例</returns>
        public GetPersonListResponse GetPersonListSync(GetPersonListRequest req)
        {
             JsonResponseModel<GetPersonListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetPersonList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPersonListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指定人员库中人员数量。
        /// </summary>
        /// <param name="req"><see cref="GetPersonListNumRequest"/></param>
        /// <returns><see cref="GetPersonListNumResponse"/></returns>
        public async Task<GetPersonListNumResponse> GetPersonListNum(GetPersonListNumRequest req)
        {
             JsonResponseModel<GetPersonListNumResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetPersonListNum");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPersonListNumResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// GetPersonListNum接口的同步版本，获取指定人员库中人员数量。
        /// </summary>
        /// <param name="req">参考<see cref="GetPersonListNumRequest"/></param>
        /// <returns>参考<see cref="GetPersonListNumResponse"/>实例</returns>
        public GetPersonListNumResponse GetPersonListNumSync(GetPersonListNumRequest req)
        {
             JsonResponseModel<GetPersonListNumResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetPersonListNum");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPersonListNumResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取人员查重接口（CheckSimilarPerson）结果。
        /// </summary>
        /// <param name="req"><see cref="GetSimilarPersonResultRequest"/></param>
        /// <returns><see cref="GetSimilarPersonResultResponse"/></returns>
        public async Task<GetSimilarPersonResultResponse> GetSimilarPersonResult(GetSimilarPersonResultRequest req)
        {
             JsonResponseModel<GetSimilarPersonResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetSimilarPersonResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetSimilarPersonResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// GetSimilarPersonResult接口的同步版本，获取人员查重接口（CheckSimilarPerson）结果。
        /// </summary>
        /// <param name="req">参考<see cref="GetSimilarPersonResultRequest"/></param>
        /// <returns>参考<see cref="GetSimilarPersonResultResponse"/>实例</returns>
        public GetSimilarPersonResultResponse GetSimilarPersonResultSync(GetSimilarPersonResultRequest req)
        {
             JsonResponseModel<GetSimilarPersonResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetSimilarPersonResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetSimilarPersonResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改人员库名称、备注、自定义描述字段名称。
        /// </summary>
        /// <param name="req"><see cref="ModifyGroupRequest"/></param>
        /// <returns><see cref="ModifyGroupResponse"/></returns>
        public async Task<ModifyGroupResponse> ModifyGroup(ModifyGroupRequest req)
        {
             JsonResponseModel<ModifyGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyGroup接口的同步版本，修改人员库名称、备注、自定义描述字段名称。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyGroupRequest"/></param>
        /// <returns>参考<see cref="ModifyGroupResponse"/>实例</returns>
        public ModifyGroupResponse ModifyGroupSync(ModifyGroupRequest req)
        {
             JsonResponseModel<ModifyGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改人员信息，包括名称、性别等。人员名称和性别修改会同步到包含该人员的所有人员库。
        /// </summary>
        /// <param name="req"><see cref="ModifyPersonBaseInfoRequest"/></param>
        /// <returns><see cref="ModifyPersonBaseInfoResponse"/></returns>
        public async Task<ModifyPersonBaseInfoResponse> ModifyPersonBaseInfo(ModifyPersonBaseInfoRequest req)
        {
             JsonResponseModel<ModifyPersonBaseInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPersonBaseInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPersonBaseInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyPersonBaseInfo接口的同步版本，修改人员信息，包括名称、性别等。人员名称和性别修改会同步到包含该人员的所有人员库。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyPersonBaseInfoRequest"/></param>
        /// <returns>参考<see cref="ModifyPersonBaseInfoResponse"/>实例</returns>
        public ModifyPersonBaseInfoResponse ModifyPersonBaseInfoSync(ModifyPersonBaseInfoRequest req)
        {
             JsonResponseModel<ModifyPersonBaseInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPersonBaseInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPersonBaseInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改指定人员库人员描述内容。
        /// </summary>
        /// <param name="req"><see cref="ModifyPersonGroupInfoRequest"/></param>
        /// <returns><see cref="ModifyPersonGroupInfoResponse"/></returns>
        public async Task<ModifyPersonGroupInfoResponse> ModifyPersonGroupInfo(ModifyPersonGroupInfoRequest req)
        {
             JsonResponseModel<ModifyPersonGroupInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPersonGroupInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPersonGroupInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyPersonGroupInfo接口的同步版本，修改指定人员库人员描述内容。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyPersonGroupInfoRequest"/></param>
        /// <returns>参考<see cref="ModifyPersonGroupInfoResponse"/>实例</returns>
        public ModifyPersonGroupInfoResponse ModifyPersonGroupInfoSync(ModifyPersonGroupInfoRequest req)
        {
             JsonResponseModel<ModifyPersonGroupInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPersonGroupInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPersonGroupInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于对一张待识别的人脸图片，在一个或多个人员库中识别出最相似的 TopN 人员，识别结果按照相似度从大到小排序。单次搜索的人员库人脸总数量不得超过 100 万张。
        /// 此接口需与[人员库管理相关接口](https://cloud.tencent.com/document/product/867/32794)结合使用。
        /// 
        /// >     
        /// - 公共参数中的签名方式请使用V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// </summary>
        /// <param name="req"><see cref="SearchFacesRequest"/></param>
        /// <returns><see cref="SearchFacesResponse"/></returns>
        public async Task<SearchFacesResponse> SearchFaces(SearchFacesRequest req)
        {
             JsonResponseModel<SearchFacesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SearchFaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchFacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// SearchFaces接口的同步版本，用于对一张待识别的人脸图片，在一个或多个人员库中识别出最相似的 TopN 人员，识别结果按照相似度从大到小排序。单次搜索的人员库人脸总数量不得超过 100 万张。
        /// 此接口需与[人员库管理相关接口](https://cloud.tencent.com/document/product/867/32794)结合使用。
        /// 
        /// >     
        /// - 公共参数中的签名方式请使用V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// </summary>
        /// <param name="req">参考<see cref="SearchFacesRequest"/></param>
        /// <returns>参考<see cref="SearchFacesResponse"/>实例</returns>
        public SearchFacesResponse SearchFacesSync(SearchFacesRequest req)
        {
             JsonResponseModel<SearchFacesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SearchFaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchFacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于对一张待识别的人脸图片，在一个或多个人员库中识别出最相似的 TopN 人员，按照人员库的维度以人员相似度从大到小顺序排列。
        /// 此接口需与[人员库管理相关接口](https://cloud.tencent.com/document/product/867/32794)结合使用。
        /// </summary>
        /// <param name="req"><see cref="SearchFacesReturnsByGroupRequest"/></param>
        /// <returns><see cref="SearchFacesReturnsByGroupResponse"/></returns>
        public async Task<SearchFacesReturnsByGroupResponse> SearchFacesReturnsByGroup(SearchFacesReturnsByGroupRequest req)
        {
             JsonResponseModel<SearchFacesReturnsByGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SearchFacesReturnsByGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchFacesReturnsByGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// SearchFacesReturnsByGroup接口的同步版本，用于对一张待识别的人脸图片，在一个或多个人员库中识别出最相似的 TopN 人员，按照人员库的维度以人员相似度从大到小顺序排列。
        /// 此接口需与[人员库管理相关接口](https://cloud.tencent.com/document/product/867/32794)结合使用。
        /// </summary>
        /// <param name="req">参考<see cref="SearchFacesReturnsByGroupRequest"/></param>
        /// <returns>参考<see cref="SearchFacesReturnsByGroupResponse"/>实例</returns>
        public SearchFacesReturnsByGroupResponse SearchFacesReturnsByGroupSync(SearchFacesReturnsByGroupRequest req)
        {
             JsonResponseModel<SearchFacesReturnsByGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SearchFacesReturnsByGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchFacesReturnsByGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于对一张待识别的人脸图片，在一个或多个人员库中识别出最相似的 TopN 人员，按照相似度从大到小排列。
        /// 
        /// 本接口会将该人员（Person）下的所有人脸（Face）进行融合特征处理，即若某个 Person 下有4张 Face ，本接口会将4张 Face 的特征进行融合处理，生成对应这个 Person 的特征，使人员搜索（确定待识别的人脸图片是某人）更加准确。
        /// 
        /// 人员搜索接口和人脸搜索接口的区别是：人脸搜索会比对该 Person 下所有 Face ，而人员搜索比对的是该 Person 的 Person 特征。
        /// >     
        /// - 公共参数中的签名方式请使用V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// - 仅支持算法模型版本（FaceModelVersion）为3.0的人员库。
        /// </summary>
        /// <param name="req"><see cref="SearchPersonsRequest"/></param>
        /// <returns><see cref="SearchPersonsResponse"/></returns>
        public async Task<SearchPersonsResponse> SearchPersons(SearchPersonsRequest req)
        {
             JsonResponseModel<SearchPersonsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SearchPersons");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchPersonsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// SearchPersons接口的同步版本，用于对一张待识别的人脸图片，在一个或多个人员库中识别出最相似的 TopN 人员，按照相似度从大到小排列。
        /// 
        /// 本接口会将该人员（Person）下的所有人脸（Face）进行融合特征处理，即若某个 Person 下有4张 Face ，本接口会将4张 Face 的特征进行融合处理，生成对应这个 Person 的特征，使人员搜索（确定待识别的人脸图片是某人）更加准确。
        /// 
        /// 人员搜索接口和人脸搜索接口的区别是：人脸搜索会比对该 Person 下所有 Face ，而人员搜索比对的是该 Person 的 Person 特征。
        /// >     
        /// - 公共参数中的签名方式请使用V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// - 仅支持算法模型版本（FaceModelVersion）为3.0的人员库。
        /// </summary>
        /// <param name="req">参考<see cref="SearchPersonsRequest"/></param>
        /// <returns>参考<see cref="SearchPersonsResponse"/>实例</returns>
        public SearchPersonsResponse SearchPersonsSync(SearchPersonsRequest req)
        {
             JsonResponseModel<SearchPersonsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SearchPersons");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchPersonsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于对一张待识别的人脸图片，在一个或多个人员库中识别出最相似的 TopN 人员，按照人员库的维度以人员相似度从大到小顺序排列。
        /// 
        /// 本接口会将该人员（Person）下的所有人脸（Face）进行融合特征处理，即若某个Person下有4张 Face，本接口会将4张 Face 的特征进行融合处理，生成对应这个 Person 的特征，使人员搜索（确定待识别的人脸图片是某人员）更加准确。
        /// 
        /// 人员搜索和人脸搜索的区别是：人脸搜索比对该 Person 下所有 Face ，而人员搜索比对的是该 Person 的 Person 特征。
        /// >     
        /// - 公共参数中的签名方式请使用V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// - 仅支持算法模型版本（FaceModelVersion）为3.0的人员库。
        /// </summary>
        /// <param name="req"><see cref="SearchPersonsReturnsByGroupRequest"/></param>
        /// <returns><see cref="SearchPersonsReturnsByGroupResponse"/></returns>
        public async Task<SearchPersonsReturnsByGroupResponse> SearchPersonsReturnsByGroup(SearchPersonsReturnsByGroupRequest req)
        {
             JsonResponseModel<SearchPersonsReturnsByGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SearchPersonsReturnsByGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchPersonsReturnsByGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// SearchPersonsReturnsByGroup接口的同步版本，用于对一张待识别的人脸图片，在一个或多个人员库中识别出最相似的 TopN 人员，按照人员库的维度以人员相似度从大到小顺序排列。
        /// 
        /// 本接口会将该人员（Person）下的所有人脸（Face）进行融合特征处理，即若某个Person下有4张 Face，本接口会将4张 Face 的特征进行融合处理，生成对应这个 Person 的特征，使人员搜索（确定待识别的人脸图片是某人员）更加准确。
        /// 
        /// 人员搜索和人脸搜索的区别是：人脸搜索比对该 Person 下所有 Face ，而人员搜索比对的是该 Person 的 Person 特征。
        /// >     
        /// - 公共参数中的签名方式请使用V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// - 仅支持算法模型版本（FaceModelVersion）为3.0的人员库。
        /// </summary>
        /// <param name="req">参考<see cref="SearchPersonsReturnsByGroupRequest"/></param>
        /// <returns>参考<see cref="SearchPersonsReturnsByGroupResponse"/>实例</returns>
        public SearchPersonsReturnsByGroupResponse SearchPersonsReturnsByGroupSync(SearchPersonsReturnsByGroupRequest req)
        {
             JsonResponseModel<SearchPersonsReturnsByGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SearchPersonsReturnsByGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchPersonsReturnsByGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 给定一张人脸图片和一个 PersonId，判断图片中的人和 PersonId 对应的人是否为同一人。PersonId 请参考[人员库管理相关接口](https://cloud.tencent.com/document/product/867/32794)。 和[人脸比对](https://cloud.tencent.com/document/product/867/32802)接口不同的是，[人脸验证](https://cloud.tencent.com/document/product/867/32806)用于判断 “此人是否是此人”，“此人”的信息已存于人员库中，“此人”可能存在多张人脸图片；而[人脸比对](https://cloud.tencent.com/document/product/867/32802)用于判断两张人脸的相似度。
        /// 
        /// >     
        /// - 公共参数中的签名方式请使用V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// </summary>
        /// <param name="req"><see cref="VerifyFaceRequest"/></param>
        /// <returns><see cref="VerifyFaceResponse"/></returns>
        public async Task<VerifyFaceResponse> VerifyFace(VerifyFaceRequest req)
        {
             JsonResponseModel<VerifyFaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "VerifyFace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyFaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// VerifyFace接口的同步版本，给定一张人脸图片和一个 PersonId，判断图片中的人和 PersonId 对应的人是否为同一人。PersonId 请参考[人员库管理相关接口](https://cloud.tencent.com/document/product/867/32794)。 和[人脸比对](https://cloud.tencent.com/document/product/867/32802)接口不同的是，[人脸验证](https://cloud.tencent.com/document/product/867/32806)用于判断 “此人是否是此人”，“此人”的信息已存于人员库中，“此人”可能存在多张人脸图片；而[人脸比对](https://cloud.tencent.com/document/product/867/32802)用于判断两张人脸的相似度。
        /// 
        /// >     
        /// - 公共参数中的签名方式请使用V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// </summary>
        /// <param name="req">参考<see cref="VerifyFaceRequest"/></param>
        /// <returns>参考<see cref="VerifyFaceResponse"/>实例</returns>
        public VerifyFaceResponse VerifyFaceSync(VerifyFaceRequest req)
        {
             JsonResponseModel<VerifyFaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "VerifyFace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyFaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 给定一张人脸图片和一个 PersonId，判断图片中的人和 PersonId 对应的人是否为同一人。PersonId 请参考[人员库管理相关接口](https://cloud.tencent.com/document/product/867/32794)。
        /// 本接口会将该人员（Person）下的所有人脸（Face）进行融合特征处理，即若某个Person下有4张 Face，本接口会将4张 Face 的特征进行融合处理，生成对应这个 Person 的特征，使人员验证（确定待识别的人脸图片是某人员）更加准确。
        /// 
        ///  和人脸比对相关接口不同的是，人脸验证相关接口用于判断 “此人是否是此人”，“此人”的信息已存于人员库中，“此人”可能存在多张人脸图片；而人脸比对相关接口用于判断两张人脸的相似度。
        /// 
        /// 
        /// >     
        /// - 公共参数中的签名方式请使用V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// - 仅支持算法模型版本（FaceModelVersion）为3.0的人员库。
        /// </summary>
        /// <param name="req"><see cref="VerifyPersonRequest"/></param>
        /// <returns><see cref="VerifyPersonResponse"/></returns>
        public async Task<VerifyPersonResponse> VerifyPerson(VerifyPersonRequest req)
        {
             JsonResponseModel<VerifyPersonResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "VerifyPerson");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyPersonResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// VerifyPerson接口的同步版本，给定一张人脸图片和一个 PersonId，判断图片中的人和 PersonId 对应的人是否为同一人。PersonId 请参考[人员库管理相关接口](https://cloud.tencent.com/document/product/867/32794)。
        /// 本接口会将该人员（Person）下的所有人脸（Face）进行融合特征处理，即若某个Person下有4张 Face，本接口会将4张 Face 的特征进行融合处理，生成对应这个 Person 的特征，使人员验证（确定待识别的人脸图片是某人员）更加准确。
        /// 
        ///  和人脸比对相关接口不同的是，人脸验证相关接口用于判断 “此人是否是此人”，“此人”的信息已存于人员库中，“此人”可能存在多张人脸图片；而人脸比对相关接口用于判断两张人脸的相似度。
        /// 
        /// 
        /// >     
        /// - 公共参数中的签名方式请使用V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// - 仅支持算法模型版本（FaceModelVersion）为3.0的人员库。
        /// </summary>
        /// <param name="req">参考<see cref="VerifyPersonRequest"/></param>
        /// <returns>参考<see cref="VerifyPersonResponse"/>实例</returns>
        public VerifyPersonResponse VerifyPersonSync(VerifyPersonRequest req)
        {
             JsonResponseModel<VerifyPersonResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "VerifyPerson");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyPersonResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
